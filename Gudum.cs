using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gudum : MonoBehaviour
{
    public float surat; //Doğrusal sürat olacak.
    public float donusSurati; //Dönüş sürati olacak.
    Rigidbody2D rb;//Fizik bileşenini ekledik.
    public Transform hedef;//Hedef değişkeni

    void Start()
    {
        hedef = GameObject.FindGameObjectWithTag("Player").transform; //Hedefi belirleyip ilklendirdik.
        rb = GetComponent<Rigidbody2D>(); //Fizik bileşeni eklenmiş oldu.
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 noktadanHedefe = hedef.position - transform.position; //Aradaki farkı aldık.
        noktadanHedefe.Normalize(); //Birim vektöre dönüştürüldü.
      float deger=Vector3.Cross(noktadanHedefe, transform.right).z; //Sağa doğru kavislendirme.Kavislendirme işlemi üç boyutluymuş. biz z ekseni doğrultusunda kavislendiriyoruz.

        if(deger>0)
        {
            rb.angularVelocity = donusSurati; //Açısal hız ayarlandı.Artı yönde sürat
        }
        if(deger<0)
        {
            rb.angularVelocity = -donusSurati;//Açısal hız ayarlandı.Eksi yönde sürat.
        }
        if(deger==0)
        {
            donusSurati = 0f; //Değerin artı veya eksi olup olmamasıyla açısal hız da değişiyor.
        }
        rb.angularVelocity = donusSurati * deger;//Açısal hızın değere göre artması
        rb.velocity = transform.right * surat * Time.deltaTime; //Sağa doğru zaman değişimine bağlı olarak yönelim.

    }
}
