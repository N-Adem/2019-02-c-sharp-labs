using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isKeyOne = false;
    bool isKeyTwo = false;
    bool isKeryThree = false;

    public void LoadMain()
    {
        SceneManager.LoadScene("LevelOne");
    }
    public void LeaveGame()
    {
        Application.Quit();
    }
}
