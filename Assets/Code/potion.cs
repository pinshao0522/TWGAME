using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potion : MonoBehaviour
{
    void Update()
    {
        this.transform.position += new Vector3(0, -0.08f, 0);
    }
}
