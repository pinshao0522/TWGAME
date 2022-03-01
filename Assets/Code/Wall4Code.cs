using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall4Code : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Monster(Clone)")
        {
            ScoreCode.Score = ScoreCode.Score - 1;
            Destroy(collision.gameObject);
        }
    }

}
