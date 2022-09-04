using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    private Text scoreTextMax;
    // Start is called before the first frame update
    void Awake()
    {
        if (ScoreManager.instance != null)
        {
            scoreTextMax = GetComponent<Text>();
             //ScoreManager.instance.LoadNameScore();
             scoreTextMax.text = ScoreManager.instance.score.ToString();
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        //scoreTextMax.text = ScoreManager.instance.score.ToString();
    }
}
