using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Button restartButton;
    public Button quitButton;
    public GameObject player;
    void Start()
    {
        restartButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Player.isDead)
        {
            player.SetActive(false);
            restartButton.gameObject.SetActive(true);
            quitButton.gameObject.SetActive(true);
        }
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}
