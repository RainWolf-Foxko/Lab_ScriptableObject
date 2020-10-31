using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AIFollowWaypointsSettings", 
menuName = "ScriptableObjects / AIFollowWaypointsSettings", order = 1)]
public class AIFollowWaypointsSettings : ScriptableObject
{
    public List<Transform> waypoints;
    public float minMoveSpeed = 0.1f;
    public float maxMoveSpeed = 1.0f;
    public float minIdleTime = 1;
    public float maxIdleTime = 3;
    public float chanceOfIdle = 50;
}