using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverUI : MonoBehaviour, IPointerEnterHandler
{  public GameObject canvas;
   public GameObject UIPrefab;
   public DraggableUI dragScript;
//    var UIImage;
   GameObject  UIImage;
   public void OnPointerEnter(PointerEventData eventData)
     {

               UIImage =   Instantiate(UIPrefab) as GameObject;
       UIImage.transform.SetParent(canvas.transform,false);
     }
 



}
