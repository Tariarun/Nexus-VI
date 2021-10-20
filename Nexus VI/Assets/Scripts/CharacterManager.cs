using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float translationUpDown = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;


        float translationLeftRight = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        transform.Translate(translationLeftRight, 0, translationUpDown);
    }
}
