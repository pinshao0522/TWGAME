using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skull : MonoBehaviour
{
    void Update()
    {
        this.transform.position += new Vector3(0, -0.05f, 0);
    }
}
