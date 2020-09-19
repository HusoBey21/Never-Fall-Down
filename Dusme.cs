using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusme : MonoBehaviour
{
    public BoxCollider2D carpisma;
    void Start()
    {
        carpisma = GetComponent<BoxCollider2D>(); //Yüklendi.
    }
    void Update()
    {
        carpisma.enabled = false; //Devre dışı
    }
    void OnCollisionEnter2D(Collision2D carpistim)
    {
        if(carpistim.gameObject.tag=="Dag" || carpistim.gameObject.tag=="Madeni")
        {
            carpisma.enabled = true; //Devrede
        }
    }
}
