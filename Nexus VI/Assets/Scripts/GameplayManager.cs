using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem; 
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;

    public GameObject pauseMenu;
    public static bool isPaused;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //DialogueLua.SetVariable("Test", 2);
    }

    void Update()
    {
        //Debug.Log(DialogueLua.GetVariable("Test").AsInt);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void EndOfGame()
    {
        if (DialogueLua.GetVariable("Bad answer").asInt >= 3 || DialogueLua.GetVariable("Empathy").asInt <= 5)
        {
            BadEnd();
        }
        else
        {
            GoodEnd();
        }
    }

    public void GoodEnd()
    {

    }

    public void BadEnd()
    {

    }
}
