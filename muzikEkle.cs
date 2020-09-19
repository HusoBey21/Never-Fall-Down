using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class muzikEkle : MonoBehaviour
{
    public Ses[] sesler;
    void Awake()
    {
        foreach(Ses ses in sesler )
        {
            ses.source = GetComponent<AudioSource>(); //Ses kaynağı ayarlandı.
            ses.source.clip = ses.clip; //Ses dosyası oynatılıyor.
            ses.source.volume = ses.volume; //Ses hacmi ayarlanıyor.
            ses.source.pitch = ses.pitch;//Ses sahası
            ses.source.loop = ses.loop; //Ses döngüsü
        }
    }
    public void oynat(string muzik)
    {
        Ses sesimiz = Array.Find(sesler, Ses => Ses.name == muzik);
        if(sesimiz==null)
        {
            Debug.LogWarning("Ses dosyası bulunamadı:" + muzik);
            return;
        }
        sesimiz.source.Play();
    }
}
