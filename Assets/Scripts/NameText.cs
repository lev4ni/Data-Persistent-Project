using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameText : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        if(ScoreManager.instance != null) 
        {
            gameObject.GetComponent<Text>().text =  ScoreManager.instance.nombre;
        }
    }

   
}
