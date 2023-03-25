using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunflowerHarvest : MonoBehaviour
{
public GameObject sunPrefab;
public float SunSpawnRate = 10f;
// GameObject currentSun; 
IEnumerator SpawnningSunCoroutine(){
  
    yield return new WaitForSeconds (SunSpawnRate);
SpawnSun();
StartCoroutine(SpawnningSunCoroutine());

} 

private void Start() {
    
    StartCoroutine(SpawnningSunCoroutine());

}


public void SpawnSun(){
 Instantiate(sunPrefab,transform.position,Quaternion.identity,transform);
}

}
