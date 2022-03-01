using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skullC : MonoBehaviour
{
    public GameObject skull;

    void Start()
    {
        InvokeRepeating("Creatskull", 2, 1);
    }

    public void Creatskull()
    {
        int skullNum;

        skullNum = Random.Range(0, 3);

        for (int i = 0; i < skullNum; i++)
        {
            float x;

            x = Random.Range(-5, 6);

            Instantiate(skull, new Vector3(x, 10f, 0), Quaternion.identity);
        }
    }
}
