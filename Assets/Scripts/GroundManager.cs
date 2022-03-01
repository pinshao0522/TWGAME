using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundManager : MonoBehaviour
{
    readonly float leftBorder = -3;//オ娩
    readonly float rightBorder = 3;//娩
    readonly float initPosotionY = 0;
    readonly int MAX_GROUND_COUNT = 10;//程狾计秖
    readonly int MIN_GROUND_COUNT_UNDER_PLAYER = 3;//產よ程ぶ狾计秖
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
    public void ControlSpawnGround()//北玻ネ狾
    {
        int groundsCountUnderPlayer = 0;//產よ狾计秖
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

    void ControlGroundsCount()//北狾计秖
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

    //璸衡穝狾Y畒夹
    float NewGroundPositionY()
    {
        if (grounds.Count == 0)
        {
            return initPosotionY;
        }
        int lowerIndex = grounds.Count - 1;
        return grounds[lowerIndex].transform.position.y - spacingY;
    }

    //玻ネ虫狾
    void SpawnGround()
    {
        GameObject newGround = Instantiate(Resources.Load<GameObject>("floor"));
        newGround.transform.position = new Vector3(NewGroundPositionX(), NewGroundPositionY(), 0);
        grounds.Add(newGround.transform);
        groundNumber++;//狾絪腹+1
        newGround.name = "floor" + groundNumber;//эン嘿狾+瑈絪腹
    }
    float CountLowerGroundFloor()
    {
        float playerPositionY = player.transform.position.y;
        float deep = Mathf.Abs(initPosotionY - playerPositionY);
        return (deep / singleFloorHeight) + 1;
    }
    void DisplayCountFloor()
    {
        displayCountFloor.text = "" + CountLowerGroundFloor().ToString("0000") + "加";
    }
    void Update()
    {
        ControlSpawnGround();
        DisplayCountFloor();
    }
}
