using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class main_menu : MonoBehaviour
{
    public void startgame()
    {
        SceneManager.LoadScene(1);
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");

    }


    public void QuitGame()

    {
        print("game has been quit");
        Application.Quit();
    }
}
