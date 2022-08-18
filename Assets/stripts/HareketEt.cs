    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HareketEt : MonoBehaviour
{
    
    public Rigidbody rb;
    bool oyunbitti = false;
    public  int puan;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        puan = 0;
    }

    
    void Update()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0,0,5,ForceMode.Force);
        }
        if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-5,ForceMode.Force);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-5,0,0,ForceMode.Force);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(5,0,0,ForceMode.Force);
        }
        

    }

   
    private void OnCollisionEnter(Collision Collision )
    {
        if(Collision.collider.tag == "bitis")
        {
            Invoke("restart", 1f);
            oyunbitti =true;


        }
        if(Collision.collider.tag == "dusman")
        {
            Invoke("restart", 1f);
            oyunbitti =true;
            

        }if ( Collision.collider.tag == "coin")
         {
            puan++;
            Destroy(Collision.gameObject);
           
         }
    }
    private void restart()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     oyunbitti =false;
     }
} 
