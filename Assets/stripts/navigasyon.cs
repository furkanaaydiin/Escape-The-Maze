using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navigasyon : MonoBehaviour
{
    public Transform player; 
    NavMeshAgent playeragent;
    void Start()
    {
        playeragent = this.GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        playeragent.destination = player.position;
    }
}
