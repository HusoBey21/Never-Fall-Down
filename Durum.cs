using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Durum : MonoBehaviour
{
    public float gorusAcisi = 110f; //Düşmanın görüş açısını belirledik.
    public bool oyuncuGoruste; //Oyuncunun görüş açısında olup olmadığını söyler.
    public Vector2 kisiselSonGorus; //Bu da oyuncunun en son ne zaman görüldüğü ile ilgilidir.
  
    private BoxCollider2D kutu;
    private GameObject oyuncu;
    private Vector2 oncekiKonum;
    void Awake()
    {
       
        kutu = GetComponent<BoxCollider2D>(); //Bu da olacak.
        oyuncuGoruste = false;
        oyuncu = GameObject.FindGameObjectWithTag("Player");
        kisiselSonGorus = oyuncu.transform.position;
        oncekiKonum = transform.position; //Önceki konumu ilklendirdim.
        

    }
    void Update()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -150f, -80f), Mathf.Clamp(transform.position.y, -110f, -60f));
        transform.position=Vector2.MoveTowards(transform.position,oyuncu.transform.position,10f*Time.deltaTime);
    }
    void oyuncuBul(Collision2D carpisma)
    {

        RaycastHit2D tespit = Physics2D.Raycast(oncekiKonum, kisiselSonGorus, Vector2.Distance(oncekiKonum, kisiselSonGorus));
        if(tespit.collider!=null && tespit.collider.tag=="Player" && carpisma.gameObject.transform.tag=="Player")
        {
            Debug.Log("Oy yandan yandan yandan");
            
            this.gameObject.GetComponent<Buyu>().atesle(carpisma);
            oyuncuGoruste = true;
        }

    }
    
}
