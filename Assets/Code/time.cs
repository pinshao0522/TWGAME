using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{

    public static int time_int = 60;

    public Text time_UI;

    public GameObject Gameover;

    void Start()
    {
        Gameover.SetActive(false);

        InvokeRepeating("timer", 1, 1);

    }

    void timer()
    {

        time_int -= 1;

        time_UI.text = time_int + "";

        if (time_int == 0)
        {

            time_UI.text = "time\nup";

            CancelInvoke("timer");

            Gameover.SetActive(true);

            Time.timeScale = 0;

        }

    }

}