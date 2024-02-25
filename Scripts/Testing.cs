using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    public GameObject gridItems;
   
   
    // Start is called before the first frame update
    void Start()
    {
        Grid gridObj = new Grid(5,8);
 float width = gridItems.GetComponent<SpriteRenderer>().bounds.size.x;
       float height = gridItems.GetComponent<SpriteRenderer>().bounds.size.y;
        gridObj.MakeGrid(gridItems,width,height,transform.position.x,transform.position.y,gameObject.GetComponent<Transform>());
    }

 
}
