using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakibi : MonoBehaviour
{
    public GameObject oyuncu;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(oyuncu.transform.position.x, oyuncu.transform.position.y, oyuncu.transform.position.z);

    }
}
