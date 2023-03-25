using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Rigidbody2D body;
   BoxCollider2D zombieCollider;
  float Health = 30f;
 float moveSpeed  = 1f;
float attackDamage = 15f;
bool isAttacking = false;
float attackRate = 3f;
GameObject victimPlant;
private void Awake() {
body = gameObject.GetComponent<Rigidbody2D>();
zombieCollider = gameObject.GetComponent<BoxCollider2D>();    
}

private void FixedUpdate() {
    Walk();
}

public void Walk(){

body.velocity = transform.right * -moveSpeed;


}

public void  takeDamage(float bulletDamage){
    if(Health>1){
        Health -= bulletDamage;
}
else{
    Destroy(gameObject);
}

}

private void OnTriggerExit2D(Collider2D other) {
    moveSpeed = 1f;
    StopAllCoroutines();
    isAttacking = false;
}

private void OnTriggerStay2D(Collider2D other) {

 if(other.gameObject.tag == "Player"){
    
      if(isAttacking)
      return;
    
       moveSpeed = 0f;
victimPlant = other.gameObject;
StartCoroutine(AttackingCoroutine());
   
    isAttacking = true;
    
    }
}



 IEnumerator AttackingCoroutine()
  {
   ZombieAttack();

yield return new WaitForSeconds(attackRate);

   isAttacking = false;

 }


public void ZombieAttack()
{
victimPlant.GetComponent<PlantHealth>().takeDamage(attackDamage);
}

}
