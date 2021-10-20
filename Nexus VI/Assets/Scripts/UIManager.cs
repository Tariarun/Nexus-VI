using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void OnClick_Pause()
    {
        if (!GameplayManager.isPaused)
        {
            GameplayManager.instance.PauseGame();
        }
        else
        {
            GameplayManager.instance.ResumeGame();
        }
    }

    public void OnClick_Scene0()
    {
        SceneManager.LoadScene(0);
    }

    public void OnClick_Scene1()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClick_Exit()
    {
        Application.Quit();
    }
}
