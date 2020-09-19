using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atlama : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D carpisan)
    {
        if(carpisan.gameObject.tag=="Dag")
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(Random.Range(0f,10f),Random.Range(0f,10f),0f) * 10f * Time.deltaTime); //Zıplayarak ilerleyecekler.
            this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 10f; //10f e eşit olacak.
        }
    }
}
