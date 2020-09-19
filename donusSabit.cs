using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donusSabit : MonoBehaviour
{
    public Transform hedef;


    // Update is called once per frame
   public void donustur()
    {
        transform.rotation = Quaternion.Euler(hedef.position.x, 0f, hedef.position.z); //İstediğimiz şey hedefteki nesneyi soluk soluğa takip etmesidir.
        Quaternion donusDegeri = transform.rotation;
        Debug.Log("Güncellenen dönüş değeri:" + donusDegeri);
    }
}
