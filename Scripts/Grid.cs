using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    private int width;
    private int height;
   
    private int[,] gridArray;

    public Grid(int height , int width)
{
    this.width = width;
    this.height = height;
    gridArray = new int[width,height];

    // Debug.Log(width + "," + height);


}


public void MakeGrid(GameObject prefab,float x_space, float y_space,float X_Start, float Y_Start,Transform parent){

for(int i = 0 ; i < height * width; i++){

        Instantiate(prefab , new Vector3(X_Start + (x_space * (i % width)),Y_Start + (y_space * (i % height))),Quaternion.identity,parent);
    
}

}
}
