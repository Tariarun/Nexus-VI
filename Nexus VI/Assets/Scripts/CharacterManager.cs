using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField]
    public Animator animator;
    public float speed;


    void Start()
    {

        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        #region mouvement

        float translationUpDown = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        float translationLeftRight = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        transform.Translate(translationLeftRight, 0, translationUpDown);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        #endregion

        #region animation
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Move", false);
            animator.SetBool("Right", false);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {

            animator.SetBool("Move", true);
            animator.SetBool("Right", true);

            animator.SetFloat("Right", Mathf.Abs(translationLeftRight) * speed);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.Z))
        {
            animator.SetBool("Move", false);
            animator.SetBool("Up", false);

        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {

            animator.SetBool("Move", true);
            animator.SetBool("Up", true);
            animator.SetFloat("Up", Mathf.Abs(translationUpDown) * speed);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("Move", false);
            animator.SetBool("Down", false);

        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {

            animator.SetBool("Move", true);
            animator.SetBool("Down", true);
            animator.SetFloat("Down", Mathf.Abs(translationUpDown) * speed);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.Q))
        {
            animator.SetBool("Move", false);
            animator.SetBool("Left", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
        {
            animator.SetBool("Move", true);
            animator.SetBool("Left", true);
            animator.SetFloat("Left", Mathf.Abs(translationUpDown) * speed);
        }
        #endregion
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
