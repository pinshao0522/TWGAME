using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomC : MonoBehaviour
{
    public GameObject boom;

    void Start()
    {
        InvokeRepeating("Creatboom", 2, 1);
    }

    public void Creatboom()
    {
        int boomNum;

        boomNum = Random.Range(0, 3);

        for (int i = 0; i < boomNum; i++)
        {
            float x;

            x = Random.Range(-5, 6);

            Instantiate(boom, new Vector3(x, 10f, 0), Quaternion.identity);
        }
    }
}
