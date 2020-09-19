using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class kayit : MonoBehaviour
{
    public int anlikIndis;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            anlikIndis = SceneManager.GetActiveScene().buildIndex; //Etkin olan sahne indisi
            PlayerPrefs.SetInt("KayitliSahne", anlikIndis);//Bu kayıt altına alındı.
            PlayerPrefs.SetFloat("X", transform.position.x);//X değeri
            PlayerPrefs.SetFloat("Y", transform.position.y);//Y değeri
            PlayerPrefs.SetFloat("Z", transform.position.z);//Z değeri
            Debug.Log("Oyun Kayıtta");
            SceneManager.LoadScene(0);
        }

    }
   

   
}
