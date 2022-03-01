using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCode : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //怪物持續向下移動
        this.transform.position += new Vector3(0, -0.03f, 0);
    }

    //如果被東西碰到
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Bullet(Clone)")
        {
            ScoreCode.Score = ScoreCode.Score + 1;
            Destroy(this.gameObject);
        }
    }

    public void MonsterDie()
    {
        Destroy(this.gameObject);
    }
}
