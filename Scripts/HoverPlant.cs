using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class HoverPlant : MonoBehaviour

{  
 GameObject husk;
GameObject currentOccupyingPlant;
public static GameObject HuskObj;



private void OnMouseEnter() {
    if(DraggableUI.isDragging){
        husk = DraggableUI.HuskTemp;
HuskObj = Instantiate(husk,transform.position,Quaternion.identity);
Debug.Log("mouse enter");


}

}

private void OnMouseExit() {
     if(DraggableUI.isDragging){
    if(HuskObj)
Destroy(HuskObj);

Debug.Log("mouse leave");    

     }
}

public void OnDrop(PlantClass plantType) {
   Debug.Log("Dropping");

if(currentOccupyingPlant )
{  Debug.Log("this is occupied");
    Destroy(HuskObj);

}

if(SunCollector.SunAmount < plantType.Cost)
{  Destroy(HuskObj);
    return;
   }  
    if(!DraggableUI.isDragging && HuskObj)
{Debug.Log("droppin");
SunCollector.SunUsage(plantType.Cost);
currentOccupyingPlant = Instantiate(plantType.plantPrefab,HuskObj.transform.position,Quaternion.identity);
 Destroy(HuskObj);

Debug.Log("dropped");

    
}

}
}