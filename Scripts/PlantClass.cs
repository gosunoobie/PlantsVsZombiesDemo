using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Plant" , menuName = "Plant")]
public class PlantClass : ScriptableObject
{

public string PlantName;
public float Health;
public float Damage;
public float FireRate;
public Sprite Artwork;
public int Cost;
public GameObject plantPrefab;
public GameObject plantSpawnTempPrefab;
public GameObject plantDragTempPrefab;

}
