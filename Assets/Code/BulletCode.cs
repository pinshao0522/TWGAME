using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCode : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //脫離父物件
        this.transform.parent = null;
        //每一偵子彈向上飛行
        this.transform.position += new Vector3(0, 0.1f, 0);
    }

    //下面這個函式是當子彈碰撞到其他物體時會執行
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //如果碰到頂端牆壁，摧毀子彈(為了不讓子彈無限飛行)
        if (collision.name == "Wall_3")
            Destroy(this.gameObject);
    }
}
