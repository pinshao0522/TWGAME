using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCreater : MonoBehaviour
{
    public GameObject Monster;

    // Start is called before the first frame update
    void Start()
    {
        //����ͦ��Ǫ��{���X(�C��@��)
        InvokeRepeating("CreatMoneter", 1, 1);
    }

    public void CreatMoneter()
    {
        int MonsterNum;
        //�H���M�w�n�ͦ��X�өǪ�(0-2���H��)
        MonsterNum = Random.Range(0, 3);
        //�}�l�ͦ��Ǫ�
        for (int i = 0; i < MonsterNum; i++)
        {
            //�ŧi�ͦ���X�y��
            float x;
            //�����H����X�y��(-5��5����)
            x = Random.Range(-5, 6);
            //�ͦ��Ǫ�
            Instantiate(Monster, new Vector3(x, 10f, 0), Quaternion.identity);
        }
    }
}
