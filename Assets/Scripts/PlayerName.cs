using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public static PlayerName instancePlayer;
    public InputField playerNameField;
    public Text texto;
    public string playerString = "";

    private void Start()
    {
       if (ScoreManager.instance != null)
        {            
            texto.text = ScoreManager.instance.nombre;
            return;
        }
    }
    public string  playerName(string name)
    {
        name = playerNameField.text;
        ScoreManager.instance.nombre = name;
        return name;
    }

    public void AsignaNombre()
    {
        playerName(name);
        SceneManager.LoadScene(1);
    }
}
