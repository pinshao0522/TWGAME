using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipController : MonoBehaviour
{
    //�ŧi�l�u����
    public GameObject Bullet;

    //�ŧi�ͩR�ƶq=3
    int HeartNum = 3;

    //�ŧi�R��1
    public GameObject Heart1;

    //�ŧi�R��2
    public GameObject Heart2;

    //�ŧi�R��3
    public GameObject Heart3;

    public GameObject Gameover;

    void Start()
    {
        Gameover.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�p�G���a���U�k��
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //�a���o�ӵ{���X������(����)�|�V�k���ܮy��
            this.transform.position += new Vector3(0.05f, 0, 0);
        }

        //�p�G���a���U����
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //�a���o�ӵ{���X������(����)�|�V�����ܮy��
            this.transform.position += new Vector3(-0.05f, 0, 0);
        }

        //�p�G���a���U�ť���
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�b(0,3,0)����m�ͦ�Bullet����A��Bullet������V�l�u����
            Instantiate(Bullet, this.transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(0);
        }
    }

    //�M�h�I����Ǫ��ɷ|����
    private void OnTriggerEnter2D(Collider2D collision)
    {      
        if (collision.name == "Monster(Clone)")
        {
            //�R���Ǫ�
            Destroy(collision.gameObject);           
            
            //�R�߼ƶq-1
            HeartNum = HeartNum - 1;

            //�ھڷR�߼ƶq�A��ܷR�߹Ϯ�
            if (HeartNum == 2) //�p�G�٦������R��
            {
                //���Ĥ@���R������
                Heart1.SetActive(false);
            }

            else if (HeartNum == 1) //�p�G�٦��@���R��
            {
                //���ĤG���R������
                Heart2.SetActive(false);
            }

            else if (HeartNum == 0) //�p�G�S���R��
            {
                //���ĤT���R������
                Heart3.SetActive(false);
                Gameover.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
