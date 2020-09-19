using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buyu : MonoBehaviour
{
    public Transform buyuNesnesi; //Büyü yapmamıza yarar.
    public Transform hedef;
    void Awake()
    {
        buyuNesnesi = GameObject.FindGameObjectWithTag("AtesDuvari").transform;
        hedef = GetComponent<Transform>();
    }
   
    
   
   public void atesle(Collision2D vurus)
    {
        if (buyuNesnesi != null)
        {
            Vector3 yonel = (hedef.position - transform.position);
            Transform vur = Instantiate(buyuNesnesi, transform.position, Quaternion.identity) as Transform; //Tip uyuşmazlığı olmasın diye.
           

            if (vur.transform.parent != null)
            {
                vur.transform.parent.GetComponent<vurucu>();
                vur.transform.parent.GetComponent<Transform>().GetComponent<Rigidbody2D>().velocity = yonel * 10f * Time.deltaTime;//Hangi hızla yollanacak.
                Quaternion gidisat = Quaternion.Lerp(transform.rotation, hedef.rotation, 10f + Time.deltaTime);
                vur.rotation = Quaternion.RotateTowards(transform.rotation, gidisat, 30f * Time.deltaTime);
                vur.position = Vector3.MoveTowards(vur.position, hedef.position, 20f * Time.deltaTime);
                Destroy(vur.gameObject, 5f);
            }
            Destroy(vur.gameObject, 5f);
            vurus.gameObject.GetComponent<Yara>().canHasari(5f);
        }
    }
    void OnCollisionEnter2D(Collision2D carpisan)
    {
        if(carpisan.gameObject.tag=="Player")
        {
            

            Debug.Log("Vurduk");
            atesle(carpisan);
            
          

        }
    }
}
