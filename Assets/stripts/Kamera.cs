using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public GameObject sphere;
    Vector3 mesafe;
    void Start()
    {
        mesafe = transform.position - sphere.transform.position;
    }

    
    void Update()
    {
           transform.position=sphere.transform.position  +mesafe;
    }
}
