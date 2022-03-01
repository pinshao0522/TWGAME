using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenchopC : MonoBehaviour
{
    public GameObject chickenchop;

    void Start()
    {
        InvokeRepeating("Creatchickenchop", 3, 1);
    }

    public void Creatchickenchop()
    {
        int chickenchopNum;

        chickenchopNum = Random.Range(0, 2);

        for (int i = 0; i < chickenchopNum; i++)
        {
            float x;

            x = Random.Range(-5, 6);

            Instantiate(chickenchop, new Vector3(x, 10f, 0), Quaternion.identity);
        }
    }
}
