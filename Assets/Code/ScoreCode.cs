using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    //�ŧi���ưѼ�
    public static int Score;
    //�ŧi��rUI
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
