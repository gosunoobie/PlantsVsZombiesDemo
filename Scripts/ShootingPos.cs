using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPos : MonoBehaviour
{
public Transform ShootingPosition;
public GameObject bulletPrefab;
public LayerMask enemyLayer;
float maxDistance = 11.5f;
Rigidbody2D bulletBody; 
BoxCollider2D bulletCollider;
public float fireRate = 3f; 
bool isShooting = false;
private void Awake() {
 bulletBody = bulletPrefab.GetComponent<Rigidbody2D>();
 bulletCollider = bulletPrefab.GetComponent<BoxCollider2D>();   

}

 IEnumerator ShootingCoroutine()
  {
   ShootBullet();

yield return new WaitForSeconds(fireRate);

   isShooting = false;

 }


private void Start() {
   
}

public void ShootBullet(){
    Instantiate(bulletPrefab, ShootingPosition);
    Debug.Log("shoot");
}

private void FixedUpdate() {
      RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.right,maxDistance,enemyLayer);

        if (hit.collider !=null)
    {
        // print("Found an object - distance: " + hit.distance);
        if(isShooting)
         return;

         StartCoroutine(ShootingCoroutine());
         isShooting = true;
   
   
    }
    else{
         StopAllCoroutines();
        //  Debug.Log("all stopped");
         isShooting = false;
    }
    


}
}
