using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuMananger : MonoBehaviour
{
    public Button StairsButton;
    public Button BombButton;
    public Button StarButton;
    public Button FoodButton;
    public Button QuitButton;

    public void StairsScene()
    {
        SceneManager.LoadScene(1);
    }
    public void BombScene()
    {
        SceneManager.LoadScene(2);
    }
    public void StarScene()
    {
        SceneManager.LoadScene(3);
    }
    public void FoodScene()
    {
        SceneManager.LoadScene(4);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
