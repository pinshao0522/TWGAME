using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    //宣告分數參數
    public static int Score;
    //宣告文字UI
    public Text ShowScore;

    public GameObject Youwin;

    public GameObject Gameover;

    void Start()
    {
        Score = 0;

        Youwin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore.text = Score.ToString();

        if (Score >= 20)
        {
            Youwin.SetActive(true);
            Time.timeScale = 0;
        }
        else if (Score < 0)
        {
            Gameover.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
