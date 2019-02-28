using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkingTarget : MonoBehaviour {

    private NavMeshAgent navMesh;

    private Transform currentDestination;

    private Transform[] waypoints;
    private int health;
    public GameObject[] healthImages;
    public GameObject destroyedTargetPrefab;

    public void Init(Transform[] _waypoints)
    {
        waypoints = _waypoints;
    }

    private void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        health = healthImages.Length;
        SetRandomNavMeshAgentDestonation();
    }

    private void Update()
    {
        float dist = navMesh.remainingDistance;
        if(!float.IsPositiveInfinity(dist) && navMesh.pathStatus == NavMeshPathStatus.PathComplete && navMesh.remainingDistance < 0.1f)
        {
            SetRandomNavMeshAgentDestonation();
        }
    }

    private void SetRandomNavMeshAgentDestonation()
    {
        int waypointIndex = Random.Range(0, waypoints.Length);
        currentDestination = waypoints[waypointIndex];
        navMesh.SetDestination(currentDestination.position);
    }

    public void TakeDamage()
    {
        health--;
        healthImages[health].SetActive(false);
        if(health <= 0)
        {
            Transform currentTransform = transform;
            GameObject go = Instantiate(destroyedTargetPrefab, currentTransform.position, currentTransform.rotation);
            Destroy(gameObject);
            Destroy(go, 3.0f);
        }
    }
}
