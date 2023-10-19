using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public Button Singleplayer_Button;
    public Button Multiplayer_Button;
    public Button Quit_Button;

    public void Singleplayer()
    {
        SceneManager.LoadScene(1);
    }

    public void Explanation()
    {
        SceneManager.LoadScene(8);
    }

    public void Multiplayer()
    {
        SceneManager.LoadScene(2);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void IMPOSSIBLE()
    {
        SceneManager.LoadScene(9);
    }

    public void Quit_game()
    {
        Application.Quit();
        Debug.Log("Closed Application");
    }
}
