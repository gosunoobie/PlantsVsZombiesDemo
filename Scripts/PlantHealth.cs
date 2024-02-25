using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantHealth : MonoBehaviour
{  public PlantClass peaShooter;
float Health;

private void Awake() {
Health = peaShooter.Health;    
}
    //   float Health = peaShooter.Health;
public void  takeDamage(float damage){
   Debug.Log("the plant is taking damage");
    if(Health>1){
        Health -= damage;
}
else{
    Destroy(gameObject);
}
}
}
