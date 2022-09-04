using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        //if(ScoreManager.instance != null)
        {

        }
    }
    public void Jugar()
    {
        SceneManager.LoadScene("main");
    }

    public void Salir()
    {
        Application.Quit();
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
