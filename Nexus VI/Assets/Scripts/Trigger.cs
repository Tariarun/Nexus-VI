using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");

        if (collision.gameObject.tag == "TaskTrigger" || collision.gameObject.tag == "New tag")
        {
            Debug.Log("Collision");
        }
    }
}
