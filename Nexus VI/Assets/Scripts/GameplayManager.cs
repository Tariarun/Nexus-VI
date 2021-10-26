using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem; 
using UnityEngine;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager instance;

    public GameObject pauseMenu;
    public static bool isPaused;

    public GameObject louisHappy, louisSad, ixieHappy, ixieSad, uhoHappy, uhoSad, valerieHappy, valerieSad, kolaboHappy, kolaboSad, duncanHappy, duncanSad, goodEnd, badEnd;

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
        Debug.Log(DialogueLua.GetVariable("Bad answer").AsInt);

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
        Debug.Log("End");
        if (DialogueLua.GetVariable("Bad answer").asInt >= 3)
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
        goodEnd.SetActive(true);
    }

    public void BadEnd()
    {
        badEnd.SetActive(false);
    }

    #region Character UI
    public void HideEveryone()
    {
        louisHappy.SetActive(false);
        louisSad.SetActive(false);
        ixieHappy.SetActive(false);
        ixieSad.SetActive(false);
        uhoHappy.SetActive(false);
        uhoSad.SetActive(false);
        valerieHappy.SetActive(false);
        valerieSad.SetActive(false);
        kolaboHappy.SetActive(false);
        kolaboSad.SetActive(false);
        duncanHappy.SetActive(false);
        duncanSad.SetActive(false);
    }

    public void ShoWLouisHappy()
    {
        HideEveryone();
        louisHappy.SetActive(true);
    }
    public void ShoWLouisSad()
    {
        HideEveryone();
        louisSad.SetActive(true);
    }
    public void ShoWIxieHappy()
    {
        HideEveryone();
        ixieHappy.SetActive(true);
    }
    public void ShoWIxieSad()
    {
        HideEveryone();
        ixieSad.SetActive(true);
    }
    public void ShoWUhoHappy()
    {
        HideEveryone();
        uhoHappy.SetActive(true);
    }
    public void ShoWUhoSad()
    {
        HideEveryone();
        uhoSad.SetActive(true);
    }
    public void ShoWValerieHappy()
    {
        HideEveryone();
        valerieHappy.SetActive(true);
    }
    public void ShoWValerieSad()
    {
        HideEveryone();
        valerieSad.SetActive(true);
    }
    public void ShoWKolaboHappy()
    {
        HideEveryone();
        kolaboHappy.SetActive(true);
    }
    public void ShoWKolaboSad()
    {
        HideEveryone();
        kolaboSad.SetActive(true);
    }
    public void ShoWDuncanHappy()
    {
        HideEveryone();
        duncanHappy.SetActive(true);
    }
    public void ShoWDuncanSad()
    {
        HideEveryone();
        duncanSad.SetActive(true);
    }
    #endregion

    #region Lua
    void OnEnable()
    {
        Lua.RegisterFunction("ShoWLouisHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWLouisHappy()));
        Lua.RegisterFunction("ShoWLouisSad", this, SymbolExtensions.GetMethodInfo(() => ShoWLouisSad()));
        Lua.RegisterFunction("ShoWIxieHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWIxieHappy()));
        Lua.RegisterFunction("ShoWIxieSad", this, SymbolExtensions.GetMethodInfo(() => ShoWIxieSad()));
        Lua.RegisterFunction("ShoWUhoHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWUhoHappy()));
        Lua.RegisterFunction("ShoWUhoSad", this, SymbolExtensions.GetMethodInfo(() => ShoWUhoSad()));
        Lua.RegisterFunction("ShoWValerieHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWValerieHappy()));
        Lua.RegisterFunction("ShoWValerieSad", this, SymbolExtensions.GetMethodInfo(() => ShoWValerieSad()));
        Lua.RegisterFunction("ShoWKolaboHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWKolaboHappy()));
        Lua.RegisterFunction("ShoWKolaboSad", this, SymbolExtensions.GetMethodInfo(() => ShoWKolaboSad()));
        Lua.RegisterFunction("ShoWDuncanHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWDuncanHappy()));
        Lua.RegisterFunction("ShoWDuncanSad", this, SymbolExtensions.GetMethodInfo(() => ShoWDuncanSad()));
        Lua.RegisterFunction("HideEveryone", this, SymbolExtensions.GetMethodInfo(() => HideEveryone()));
        Lua.RegisterFunction("EndOfGame", this, SymbolExtensions.GetMethodInfo(() => EndOfGame()));
    }

    /*void OnDisable()
    {
        Lua.RegisterFunction("ShoWLouisHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWLouisHappy()));
        Lua.RegisterFunction("ShoWLouisSad", this, SymbolExtensions.GetMethodInfo(() => ShoWLouisSad()));
        Lua.RegisterFunction("ShoWIxieHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWIxieHappy()));
        Lua.RegisterFunction("ShoWIxieSad", this, SymbolExtensions.GetMethodInfo(() => ShoWIxieSad()));
        Lua.RegisterFunction("ShoWUhoHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWUhoHappy()));
        Lua.RegisterFunction("ShoWUhoSad", this, SymbolExtensions.GetMethodInfo(() => ShoWUhoSad()));
        Lua.RegisterFunction("ShoWValerieHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWValerieHappy()));
        Lua.RegisterFunction("ShoWValerieSad", this, SymbolExtensions.GetMethodInfo(() => ShoWValerieSad()));
        Lua.RegisterFunction("ShoWKolaboHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWKolaboHappy()));
        Lua.RegisterFunction("ShoWKolaboSad", this, SymbolExtensions.GetMethodInfo(() => ShoWKolaboSad()));
        Lua.RegisterFunction("ShoWDuncanHappy", this, SymbolExtensions.GetMethodInfo(() => ShoWDuncanHappy()));
        Lua.RegisterFunction("ShoWDuncanSad", this, SymbolExtensions.GetMethodInfo(() => ShoWDuncanSad()));
        Lua.RegisterFunction("HideEveryone", this, SymbolExtensions.GetMethodInfo(() => HideEveryone()));
    }*/
    #endregion
}
