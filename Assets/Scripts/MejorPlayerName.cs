using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MejorPlayerName : MonoBehaviour
{
    void Start()
    {
        if (ScoreManager.instance != null)
        {
            gameObject.GetComponent<Text>().text = ScoreManager.instance.mejorPlayer.ToString();
        }
    }
}
