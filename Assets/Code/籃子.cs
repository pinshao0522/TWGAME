using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 籃子 : MonoBehaviour
{
    public GameObject gameover;

    void Start()
    {
        gameover.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += new Vector3(0.05f, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += new Vector3(-0.05f, 0, 0);
        }

        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "珍奶(Clone)")
        {
            score.Score = score.Score + 1;
            Destroy(collision.gameObject);
        }
        else if (collision.name == "臭豆腐(Clone)")
        {
            score.Score = score.Score + 3;
            Destroy(collision.gameObject);
        }
        else if (collision.name == "雞排(Clone)")
        {
            score.Score = score.Score + 5;
            Destroy(collision.gameObject);
        }
        else if (collision.name == "炸彈(Clone)")
        {
            Destroy(collision.gameObject);
            gameover.SetActive(true);
            Time.timeScale = 0;
        }
        else if (collision.name == "藥水(Clone)")
        {
            Destroy(collision.gameObject);
            time.time_int = time.time_int + 5;
        }
        else if (collision.name == "骷髏頭(Clone)")
        {
            Destroy(collision.gameObject);
            time.time_int = time.time_int - 5;
        }
    }
}
