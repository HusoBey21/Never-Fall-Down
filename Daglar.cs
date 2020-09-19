using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daglar : MonoBehaviour
{
    public Rigidbody2D rb; //Oyuna fizik ekledik.
    


  
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        
        
            Debug.Log("Vurun ulan vurun vurun");
            Invoke("Don", 1f); //Donmeyi sağlar.
            Invoke("sol",2f);
        
    }
    void Don()
    {
        transform.Translate(-10f*Time.deltaTime,0f*Time.deltaTime,0f*Time.deltaTime); //Böyle dönmüş oluyorsun.
    }
    void sol()
    {
        transform.Translate(10f * Time.deltaTime, 0f * Time.deltaTime, 0f * Time.deltaTime);
    }
}
