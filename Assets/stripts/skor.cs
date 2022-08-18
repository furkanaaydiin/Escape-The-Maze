using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{
    public Text sc;
    public  HareketEt hareketEt; 
    void Start()
    {
        
    }

    
    void Update()
    {
        sc.text ="GOLD : " + hareketEt.puan.ToString();
    }
}
