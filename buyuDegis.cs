using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyuDegis : MonoBehaviour
{
    public Transform[] buyuler; //Büyülerin tutulduğu bir dizi
    public int suankiBuyu = 0; //Bu büyünün indisini verir.
    public GameObject[] dusman;
    void Start()
    {

        dusman = GameObject.FindGameObjectsWithTag("Düşman"); //Düşman etiketli tüm nesneler dizide olacak.
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            suankiBuyu++;
            if (suankiBuyu > buyuler.Length)
            {
                suankiBuyu = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            
           
                Transform buyucu = Instantiate(buyuler[suankiBuyu], transform.position, Quaternion.identity) as Transform;
            if (buyucu.transform.parent != null)
            {
                buyucu.transform.parent.GetComponent<vurDusmana>();
            }
                for (int t = 0; t < dusman.Length; t++)
                {
                    buyucu.LookAt(dusman[t].transform);
                    Vector2 yonelim = dusman[t].transform.position - transform.position; //Yönelme durumu.
                    buyucu.gameObject.GetComponentInParent<Rigidbody2D>().velocity = yonelim * 10f * Time.deltaTime;//Böyle olacak.
                }
                Destroy(buyucu.gameObject, 5f); //5 saniye içinde yok olacak.
            

        }
    }
}
