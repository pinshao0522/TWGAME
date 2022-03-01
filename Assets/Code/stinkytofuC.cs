using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stinkytofuC: MonoBehaviour
{
    public GameObject stinkytofu;

    void Start()
    {
        InvokeRepeating("Creatstinkytofu", 2, 1);
    }

    public void Creatstinkytofu()
    {
        int stinkytofuNum;

        stinkytofuNum = Random.Range(0, 3);

        for (int i = 0; i < stinkytofuNum; i++)
        {
            float x;

            x = Random.Range(-5, 6);

            Instantiate(stinkytofu, new Vector3(x, 10f, 0), Quaternion.identity);
        }
    }
}
