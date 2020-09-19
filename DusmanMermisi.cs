using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusmanMermisi : MonoBehaviour
{
    float surat; //Sürat 
    Vector2 yon; //Merminin yönü
    bool hazirMi; //Yönün ne zaman devrede olduğunu bilmek için.
    void Awake()
    {
        surat = 5f;
        hazirMi = false; //Yanlışta
    }
    //Merminin yönünü ayarlamak için fonksiyon
   public void yonAyarla(Vector2 yonlu)
    {
        yon = yon.normalized; //Yön vektörünün büyüklüğü 1'dir.
        hazirMi = true; //Hazır duruuma geçti.
    }
    void Update()
    {
        if(hazirMi)
        {
            Vector2 konum = transform.position;
            konum += yon * surat*Time.deltaTime; //Zamanla mermi yönünün koordinatları artış gösterecek.
            //Konum güncelleme
            transform.position = konum; //Konumumuz güncellendi.
            Vector2 solAlt = Camera.main.ViewportToWorldPoint(new Vector2(0, 0)); // Ekranın sol alt noktası
            Vector2 sagUst = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)); //Ekranın sağ üst noktası
            if((transform.position.x<solAlt.x) || (transform.position.x > sagUst.x) || (transform.position.y > sagUst.y) || (transform.position.y > solAlt.y))
            {
                Destroy(gameObject); //Yok olacak
            }


        }
    }

}
