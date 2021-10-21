using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject txt;
    public Image image;
    public GameObject img;

    // Start is called before the first frame update
    void Start()
    {
        image.GetComponent<Image>().color = new Color(0, 0, 0, 1);
        StartCoroutine(StopBlack());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BlackF()
    {
        StartCoroutine(Black());
    }

    IEnumerator Book()
    {
        yield return new WaitForSeconds(2.5f);
        StartCoroutine(Black());
        img.SetActive(true);
    }

    IEnumerator Black()
    {
        yield return new WaitForSeconds(2f);
        image.GetComponent<Image>().color = new Color(0, 0, 0, 1);
        
    }

    IEnumerator StopBlack()
    {
        yield return new WaitForSeconds(1f);
        image.GetComponent<Image>().color = new Color(0, 0, 0, 0);
        txt.SetActive(true);
    }

    public void OnClick_Book()  //Show game's rules
    {
        StartCoroutine(Book());
    }
    public void OnClick_Level1()
    {
        SceneManager.LoadScene(1);
    }
}
