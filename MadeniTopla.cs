using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MadeniTopla : MonoBehaviour
{
    int sayac = 0;
    public Text metin;
    string Miktar;
    public AudioSource sesKaynagi;
    public AudioClip clib;
    
    void Start()
    {
        sesKaynagi = GetComponent<AudioSource>();
        
    }
    private void OnTriggerEnter2D(Collider2D carpistik)
    {
        if(carpistik.gameObject.tag=="Madeni")
        {
            Debug.Log("Madenler");
            sayac+=1; //1 arttırdık.
            Destroy(carpistik.gameObject);
            if(!sesKaynagi.isPlaying)
            {
                sesKaynagi.clip = clib;
                sesKaynagi.Play();
            }

           
            
        }
        if(carpistik.gameObject.tag=="Tas")
        {
            Debug.Log("Taşlar");
            sayac -= 1;
            Destroy(carpistik.gameObject);
            if(sayac<=0)
            {
                sayac = 0;
            }

        }
    }
   void Update()
    {
        Miktar = "Coin:" + " "+ sayac.ToString(); //Burada madeni para miktarı tutulacak.
        metin.text = Miktar;
    }
}
