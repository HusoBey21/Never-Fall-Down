using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class arttir1 : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Image>().fillAmount += 10f * Time.deltaTime;
        if(this.GetComponent<Image>().fillAmount==1)
        {
             int yukleme = PlayerPrefs.GetInt("KayitliSahne");//Kayıtlı sahneyi çalıştırır.
            if (yukleme >= 0)
            {
                SceneManager.LoadScene(yukleme);
                transform.position = new Vector3(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y"), PlayerPrefs.GetFloat("Z"));
            }
            else
                return;
        }
    }
}
