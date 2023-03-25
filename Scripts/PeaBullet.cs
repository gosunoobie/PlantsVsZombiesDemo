using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeaBullet : MonoBehaviour
{ 
float movementSpeed = 4f;
Rigidbody2D peaBullet;
float delay  = 0.1f;
public float damage = 10f;
private void Awake() {
   peaBullet = gameObject.GetComponent<Rigidbody2D>();
}

private void FixedUpdate() {
    BulletMove();
}

public void BulletMove(){
 peaBullet.velocity = transform.right * movementSpeed ;  
}


void OnTriggerEnter2D(Collider2D col)
    {
if(col.gameObject.tag != "Enemy")
return;

    col.gameObject.GetComponent<Zombie>().takeDamage(damage);
    Destroy(gameObject,delay);
    
    }


}
