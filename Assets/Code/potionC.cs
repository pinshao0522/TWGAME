using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionC : MonoBehaviour
{
    public GameObject potion;

    void Start()
    {
        InvokeRepeating("Creatpotion", 5, 1);
    }

    public void Creatpotion()
    {
        int potionNum;

        potionNum = Random.Range(0, 2);

        for (int i = 0; i < potionNum; i++)
        {
            float x;

            x = Random.Range(-5, 6);

            Instantiate(potion, new Vector3(x, 10f, 0), Quaternion.identity);
        }
    }
}
