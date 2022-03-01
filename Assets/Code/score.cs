using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int Score;

    public Text ShowScore;

    public GameObject Youwin;

    void Start()
    {
        Score = 0;

        Youwin.SetActive(false);
    }

    void Update()
    {
        ShowScore.text = Score.ToString();

        if (Score >= 200)
        {
            Youwin.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
