using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Task : MonoBehaviour
{
    public static Task instance;

    [HideInInspector] public bool isWorking = false;
    [HideInInspector] public float gaugeValue, addValue, goalValue;
    [HideInInspector] public string button;
    public TextMeshProUGUI buttonUI;
    public Slider gauge;
    public GameObject ui;

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

    public void StartTask(string input)
    {
        gaugeValue = 0f;
        goalValue = 100f;
        addValue = 0.1f;

        button = input;
        buttonUI.text = button.ToUpper();
        ui.SetActive(true);
        isWorking = true;
    }

    private void Update()
    {
        if (isWorking)
        {
            if (gaugeValue >= goalValue)
            {
                EndTask();
            }

            gauge.value = gaugeValue;

            if (Input.GetKey(button))
            {
                gaugeValue += addValue;
            }
        }
    }

    public void EndTask()
    {
        isWorking = false;
        ui.SetActive(false);
    }

    public void TriggerTask()
    {
        StartTask("e");
    }
}
