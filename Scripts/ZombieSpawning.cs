using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawning : MonoBehaviour
{
public GameObject ZombiePrefab;
 float SpawingTime = 10f;
IEnumerator spawningCoroutine (){
    SpawnZombie();

    yield return new WaitForSeconds(SpawingTime);

    StartCoroutine(spawningCoroutine());
}


private void Start() {
    StartCoroutine(spawningCoroutine());
}

public void SpawnZombie(){
    Instantiate(ZombiePrefab, transform);
}

}
