using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isik : MonoBehaviour
{
    public GameObject player;
    Vector3 mesafe;
    void Start()
    {
        mesafe = transform.position - player.transform.position;
    }

    
    void Update()
    {
        transform.position=player.transform.position  +mesafe;
    }
}
