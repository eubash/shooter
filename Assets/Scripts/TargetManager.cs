using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour 
{
    [Header("Bouncy Target")]
    public int maxBouncyTargetCount = 2;
    private int curBouncyTargetCount = 0;

    public Transform bouncyRespPoint;

    public GameObject bouncyTargetPrefab;

    public void InstantiateBouncyTarget()
    {
        if(curBouncyTargetCount < maxBouncyTargetCount) {
            Instantiate(bouncyTargetPrefab, bouncyRespPoint.position, bouncyRespPoint.rotation);
            curBouncyTargetCount++;
        }
    }

    [Header("Heavy Target")]
    public int maxHeavyTargetCount = 3;
    private int curHeavyTargetCount = 0;

    public Transform heavyRespPoint;

    public GameObject heavyTargetPrefab;

    public void InstantiateHeavyTarget()
    {
        if(curHeavyTargetCount < maxHeavyTargetCount) {
            Instantiate(heavyTargetPrefab, heavyRespPoint.position, heavyRespPoint.rotation);
            curHeavyTargetCount++;
        }
    }

    [Header("Float Target")]
    public int maxFloatTargetCount = 3;
    private int curFloatTargetCount = 0;

    public Transform floatRespPoint;

    public GameObject floatTargetPrefab;

    public void InstantiateFloatTarget()
    {
        if (curFloatTargetCount < maxFloatTargetCount)
        {
            Instantiate(floatTargetPrefab, floatRespPoint.position, floatRespPoint.rotation);
            curFloatTargetCount++;
        }
    }

    [Header("Zombie Target")]
    public int maxZombieTargetCount = 2;
    private int curZombieTargetCount = 0;

    public Transform zombieRespPoint;

    public GameObject zombieTargetPrefab;

    public void InstantiateZombieTarget()
    {
        if (curZombieTargetCount < maxZombieTargetCount)
        {
            Instantiate(zombieTargetPrefab, zombieRespPoint.position, zombieRespPoint.rotation);
            curZombieTargetCount++;
        }
    }

    [Header("Walking Target")]
    public Transform walkingTargetResp;
    public Transform[] walkingTargetWaypoints;
    public GameObject walkingTargetPrefab;

    public void InstantiateWalkingTarget ()
    {
        GameObject walkingTarget = Instantiate(walkingTargetPrefab, walkingTargetResp.position, walkingTargetResp.rotation);
        walkingTarget.GetComponent<WalkingTarget>().Init(walkingTargetWaypoints);
    }
}
