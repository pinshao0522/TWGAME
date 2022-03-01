using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundManager : MonoBehaviour
{
    readonly float leftBorder = -3;//�����
    readonly float rightBorder = 3;//�k���
    readonly float initPosotionY = 0;
    readonly int MAX_GROUND_COUNT = 10;//�̤j�a�O�ƶq
    readonly int MIN_GROUND_COUNT_UNDER_PLAYER = 3;//���a�U��̤֦a�O�ƶq
    static int groundNumber = -1;
    public float spacingY;
    public float singleFloorHeight;
    public List<Transform> grounds;
    public Transform player;
    public Text displayCountFloor;


    void Start()
    {
        grounds = new List<Transform>();
        for (int i = 0; i < MAX_GROUND_COUNT; i++)
        {
            SpawnGround();
        }
    }
    public void ControlSpawnGround()//����ͦa�O
    {
        int groundsCountUnderPlayer = 0;//���a�U�誺�a�O�ƶq
        foreach (Transform ground in grounds)
        {
            if (ground.position.y < player.transform.position.y)
            {
                groundsCountUnderPlayer++;
            }
        }

        if (groundsCountUnderPlayer < MIN_GROUND_COUNT_UNDER_PLAYER)
        {
            SpawnGround();
            ControlGroundsCount();
        }

    }

    void ControlGroundsCount()//����a�O�ƶq
    {
        if (grounds.Count > MAX_GROUND_COUNT)
        {
            Destroy(grounds[0].gameObject);
            grounds.RemoveAt(0);
        }
    }
    float NewGroundPositionX()
    {
        if (grounds.Count == 0)
        {
            return 0;
        }
        return Random.Range(leftBorder, rightBorder);
    }

    //�p��s�a�O��Y�y��
    float NewGroundPositionY()
    {
        if (grounds.Count == 0)
        {
            return initPosotionY;
        }
        int lowerIndex = grounds.Count - 1;
        return grounds[lowerIndex].transform.position.y - spacingY;
    }

    //���ͳ�@�a�O
    void SpawnGround()
    {
        GameObject newGround = Instantiate(Resources.Load<GameObject>("floor"));
        newGround.transform.position = new Vector3(NewGroundPositionX(), NewGroundPositionY(), 0);
        grounds.Add(newGround.transform);
        groundNumber++;//�a�O�s��+1
        newGround.name = "floor" + groundNumber;//�ק磌��W�٬��a�O+�y���s��
    }
    float CountLowerGroundFloor()
    {
        float playerPositionY = player.transform.position.y;
        float deep = Mathf.Abs(initPosotionY - playerPositionY);
        return (deep / singleFloorHeight) + 1;
    }
    void DisplayCountFloor()
    {
        displayCountFloor.text = "�a�U" + CountLowerGroundFloor().ToString("0000") + "��";
    }
    void Update()
    {
        ControlSpawnGround();
        DisplayCountFloor();
    }
}
