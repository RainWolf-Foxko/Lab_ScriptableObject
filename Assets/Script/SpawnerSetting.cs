using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnerSetting", 
menuName = "ScriptableObjects / SpawnerSetting", order = 1)]
public class SpawnerSetting : ScriptableObject
{
    
    public GameObject SpawnObject;
    public float X = 0f;
    public float Y = 0f;
    public float Z = 0f;
    public float R = 0f;
    public float G = 0f;
    public float B = 0f;
    public float nextSpawnTime = 0;
    public float destroyTime = 0;
}