using UnityEngine;
using System.Collections;

public class Grid
{
    // 网格本身
    public static int w = 10; // 这是宽度
    public static int h = 13; //这是高度
    public static Element[,] elements = new Element[w, h];

    //显示所有地雷
    public static void uncoverMines()
    {
        foreach (Element elem in elements)
            if (elem.mine)
                elem.loadTexture(0);
    }

    //判断给定坐标处是否是地雷
    public static bool mineAt(int x, int y)
    {
        //坐标是否在范围内？然后检测是否是地雷。
        if (x >= 0 && y >= 0 && x < w && y < h)
            return elements[x, y].mine;
        return false;
    }
    //计算一个元素的邻接地雷数
    public static int adjacentMines(int x, int y)
    {
        int count = 0;

        if (mineAt(x, y + 1)) ++count; // 上
        if (mineAt(x + 1, y + 1)) ++count; // 右上
        if (mineAt(x + 1, y)) ++count; // 右
        if (mineAt(x + 1, y - 1)) ++count; //右下
        if (mineAt(x, y - 1)) ++count; // 下
        if (mineAt(x - 1, y - 1)) ++count; //左下
        if (mineAt(x - 1, y)) ++count; // 左
        if (mineAt(x - 1, y + 1)) ++count; // 左上
        return count;
    }

    // 泛洪空元素
    public static void FFuncover(int x, int y, bool[,] visited)
    {
        // 坐标是否在范围内？
        if (x >= 0 && y >= 0 && x < w && y < h)
        {
            //已访问过？
            if (visited[x, y])
                return;

            // 显示元素
            elements[x, y].loadTexture(adjacentMines(x, y));

            // 接近地雷了？那不必继续下去了
            if (adjacentMines(x, y) > 0)
                return;

            // 设置访问标志
            visited[x, y] = true;

            //递归
            FFuncover(x - 1, y, visited);
            FFuncover(x + 1, y, visited);
            FFuncover(x, y - 1, visited);
            FFuncover(x, y + 1, visited);
        }
    }

    public static bool isFinished()
    {

        foreach (Element elem in elements)
            if (elem.isCovered() && !elem.mine)
                return false;
        // 这里没有 => 这是所有的地雷了 => 游戏胜利
        return true;
    }
}
