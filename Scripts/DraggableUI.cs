using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableUI : MonoBehaviour, IPointerDownHandler, IBeginDragHandler , IEndDragHandler ,IDragHandler, IPointerUpHandler
{

public Canvas canvas;
RectTransform rectTransform;
Transform destination;
GameObject UIImage;

public static bool isDragging = false;
public HoverPlant plantSlotScript;
public PlantClass plantObject;

public static GameObject HuskTemp;

public void OnPointerUp(PointerEventData eventData){
Destroy(UIImage);
}

public void OnPointerDown(PointerEventData eventData){
    Debug.Log("mouse down");
           UIImage =   Instantiate(plantObject.plantDragTempPrefab) as GameObject;
       UIImage.transform.SetParent(canvas.transform,false);
       rectTransform = UIImage.GetComponent<RectTransform>();
       HuskTemp = plantObject.plantSpawnTempPrefab;
} 
public void OnDrag(PointerEventData eventData){
    // Debug.Log("dragging");

    isDragging = true;
rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
}
public void OnBeginDrag(PointerEventData eventData){
    Debug.Log("mouse begin drag");
    
}


// public void ShowDraggingItem(GameObject image){

// }


public void OnEndDrag(PointerEventData eventData){
 
 isDragging = false;
 plantSlotScript.OnDrop(plantObject);
    Destroy(UIImage);

    
    Debug.Log("drag end");
}

}
