using UnityEngine;
using System.Collections;

public class Element : MonoBehaviour
{

    // 这是一颗地雷吗？
    public bool mine;
    public GameObject gameObject;

    // 不同纹理
    public Sprite[] emptyTextures;
    public Sprite mineTexture;
   


    //初始化
    void Start()
    {
        gameObject.SetActive(false);
        //随机决定它是否是一颗地雷
        mine = Random.value < 0.15;

        // 注册到网格
        int x = (int)transform.position.x;
        int y = (int)transform.position.y;
        Grid.elements[x, y] = this;
    }

    //加载另一个纹理
    public void loadTexture(int adjacentCount)
    {
        if (mine)
            GetComponent<SpriteRenderer>().sprite = mineTexture;
        else
            GetComponent<SpriteRenderer>().sprite = emptyTextures[adjacentCount];
    }

    //是否被覆盖？
    public bool isCovered()
    {
        return GetComponent<SpriteRenderer>().sprite.texture.name == "default";
    }

    void OnMouseUpAsButton()
    {
        // 这是个地雷
        if (mine)
        {
            // 显示所有地雷
            Grid.uncoverMines();
            //游戏结束
            print("you lose");
            gameObject.SetActive(true);
            
        }
        //这不是个地雷
        else
        {
            //显示邻接地雷数
            int x = (int)transform.position.x;
            int y = (int)transform.position.y;
            loadTexture(Grid.adjacentMines(x, y));

            //显示所有无雷区域
            Grid.FFuncover(x, y, new bool[Grid.w, Grid.h]);

            // 判断游戏是否已获胜
            if (Grid.isFinished())
                print("you win");
        }
    }
  
}