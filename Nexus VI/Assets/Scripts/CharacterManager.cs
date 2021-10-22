using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        float translationUpDown = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        float translationLeftRight = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        transform.Translate (translationLeftRight, 0, translationUpDown);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        //Debug.Log(translationUpDown + "/" + translationLeftRight);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");

        if (collision.gameObject.tag == "TaskTrigger")
        {
            collision.gameObject.SetActive(false);
            Task.instance.StartTask("e");
        }
    }
}
