using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCode : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //����������
        this.transform.parent = null;
        //�C�@���l�u�V�W����
        this.transform.position += new Vector3(0, 0.1f, 0);
    }

    //�U���o�Ө禡�O��l�u�I�����L����ɷ|����
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�p�G�I�쳻������A�R���l�u(���F�����l�u�L������)
        if (collision.name == "Wall_3")
            Destroy(this.gameObject);
    }
}
