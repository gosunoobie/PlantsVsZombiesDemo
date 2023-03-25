using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunScript : MonoBehaviour
{

    public Transform destination;
    public Transform parentPosition;
// public SunCollector SunCollectorScript;
  bool isCollecting =false;

    // Start is called before the first frame update
// private void OnMouseEnter() {
//     isCollecting = true;
//     Debug.Log("mouse down");
   
// }
private void OnMouseOver() {
      isCollecting = true;
    Debug.Log("mouse down");
}

IEnumerator  DestroySun(){

yield return new  WaitForSeconds(0.5f);

Destroy(gameObject);
// SunCollectorScript.SunCollect();
}

private void Update() {
    if(isCollecting){

        parentPosition.position = Vector3.Lerp(parentPosition.position,destination.position,Time.deltaTime * 2f); 
    
    if(parentPosition.position == destination.position)
    isCollecting = false;
    }
}
  private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag != "Collector")
    return;

    StartCoroutine(DestroySun());
  }
}
