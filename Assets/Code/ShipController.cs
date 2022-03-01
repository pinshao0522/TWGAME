using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipController : MonoBehaviour
{
    //宣告子彈物件
    public GameObject Bullet;

    //宣告生命數量=3
    int HeartNum = 3;

    //宣告愛心1
    public GameObject Heart1;

    //宣告愛心2
    public GameObject Heart2;

    //宣告愛心3
    public GameObject Heart3;

    public GameObject Gameover;

    void Start()
    {
        Gameover.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //如果玩家按下右鍵
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //帶有這個程式碼的物件(飛船)會向右改變座標
            this.transform.position += new Vector3(0.05f, 0, 0);
        }

        //如果玩家按下左鍵
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //帶有這個程式碼的物件(飛船)會向左改變座標
            this.transform.position += new Vector3(-0.05f, 0, 0);
        }

        //如果玩家按下空白鍵
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //在(0,3,0)的位置生成Bullet物件，而Bullet物件指向子彈物件
            Instantiate(Bullet, this.transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(0);
        }
    }

    //騎士碰撞到怪物時會執行
    private void OnTriggerEnter2D(Collider2D collision)
    {      
        if (collision.name == "Monster(Clone)")
        {
            //刪除怪物
            Destroy(collision.gameObject);           
            
            //愛心數量-1
            HeartNum = HeartNum - 1;

            //根據愛心數量，顯示愛心圖案
            if (HeartNum == 2) //如果還有兩顆愛心
            {
                //讓第一顆愛心隱藏
                Heart1.SetActive(false);
            }

            else if (HeartNum == 1) //如果還有一顆愛心
            {
                //讓第二顆愛心隱藏
                Heart2.SetActive(false);
            }

            else if (HeartNum == 0) //如果沒有愛心
            {
                //讓第三顆愛心隱藏
                Heart3.SetActive(false);
                Gameover.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
