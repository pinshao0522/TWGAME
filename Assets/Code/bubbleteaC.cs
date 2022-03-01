using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleteaC: MonoBehaviour
{
    public GameObject bubbletea;

    void Start()
    {
        InvokeRepeating("Creatbubbletea", 1, 1);
    }

    public void Creatbubbletea()
    {
        int bubbleteaNum;

        bubbleteaNum = Random.Range(0, 3);

        for (int i = 0; i < bubbleteaNum; i++)
        {
            float x;

            x = Random.Range(-5, 6);
            
            Instantiate(bubbletea, new Vector3(x, 10f, 0), Quaternion.identity);
        }
    }
}
