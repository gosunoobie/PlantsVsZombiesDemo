using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SunCollector : MonoBehaviour
{
    
public static TMP_Text TextField; 
 public static int SunAmount = 100;
 int SunValue = 50;
//  string SunAmountString = "";

private void Awake(){
    TextField = FindObjectOfType<TMP_Text>();
      TextField.text = "" + SunAmount;
}

public static void SunUsage(int cost){
      SunAmount -=cost;
    TextField.text = "" + SunAmount;
}


public void SunCollect(){
    Debug.Log("suncollected sucessfully");
    SunAmount +=SunValue;
    TextField.text = "" + SunAmount;
    Debug.Log(TextField.text);
}
  private void OnTriggerEnter2D(Collider2D other) {
    if(other.tag != "Sun")
    return;
SunCollect();

  }

}
