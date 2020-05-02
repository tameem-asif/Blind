﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavMeshScript : MonoBehaviour
{

    [SerializeField]

    Transform _destination;
    NavMeshAgent _navMeshAgent;

    void Start()
    {

        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if(_navMeshAgent == null)

        {
            Debug.LogError("ty");
    
        }
        else
        {
            SetDestination();
        }
    }

    void Update()
    {
        SetDestination();
    }

    private void SetDestination()
    {
        if(_destination != null)

        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);

        }
    }
}