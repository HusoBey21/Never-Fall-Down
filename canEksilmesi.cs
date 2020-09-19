using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canEksilmesi : MonoBehaviour
{
     Transform[] hedef;
    void Start()
    {
        hedef = new Transform[8];
        for(int a=0;a<hedef.Length;a++)
        {
            hedef[a] = GameObject.FindGameObjectWithTag("Düşman").transform;
        }
    }
    void Update()
    {
        foreach (Transform hedefim in hedef)
        {
            Vector2 uzaklik = hedefim.position - transform.position;
            transform.position = Vector2.Lerp(transform.position, uzaklik, 10f * Time.deltaTime); //Kullanılan hedefe yönelir.
        }
    }
   void OnCollisionEnter2D(Collision2D carpisik)
    {
        if(carpisik.gameObject.tag=="Düşman")
        {
            Debug.Log("Patates");
            carpisik.gameObject.GetComponent<Sagligim>().canHasari(5f); //Can hasarına uğrayacak.
        }
    }
}
