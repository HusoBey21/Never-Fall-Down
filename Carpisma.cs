using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpisma : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D carpismak)
    {
        if(carpismak.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
