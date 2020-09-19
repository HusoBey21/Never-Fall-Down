using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class arttir : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Image>().fillAmount += 10f * Time.deltaTime;
        if(this.GetComponent<Image>().fillAmount==1)
        {
            SceneManager.LoadScene("BirinciBolum");
        }
    }
}
