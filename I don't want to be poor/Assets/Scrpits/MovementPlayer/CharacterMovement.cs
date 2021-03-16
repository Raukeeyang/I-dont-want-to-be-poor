using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //Movement Animation & code
    public Animator animator;
    public bool moving = false;
    public float speed = 5.0f;

    //Win and Lose System
    public GameObject loseScreen;
    public GameObject wallet;


    // Update is called once per frame
    void Update()
    {
        if (moving == true)
        {
            movement();
        }
        movementCheck();
    }

    //Movement player
    public void SetMoving(bool val)
    {
        moving = val;
    }

    void movement()
    {
        if(Input.GetKey(KeyCode.W))
            {
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
            animator.SetFloat("Horizontal", Vector3.up.x);
            moving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            animator.SetFloat("Horizontal", Vector3.down.x);
            moving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            animator.SetFloat("Vertical", Vector3.right.y);
            moving = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            animator.SetFloat("Vertical", Vector3.left.y);
            moving = true;
        }

        animator.SetFloat("Speed", Vector3.SqrMagnitude(Vector3.one));

    }

    void movementCheck ()
    {
        if (Input.GetKey(KeyCode.D) != true && Input.GetKey(KeyCode.A) != true && Input.GetKey(KeyCode.S) != true && Input.GetKey(KeyCode.W) != true)
        {
            moving = false;
        }
        else
        {
            moving = true;
        }
    }

    //Lose system
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        { 
            Time.timeScale = 0; 
            Debug.Log ("Choca");
            loseScreen.SetActive(true);
        }

        if (collision.gameObject.tag == "Goal")
        {
            Win();
        }
    }

    //Win system

    public void Win()
    {
        Debug.Log("You win!");
    }
}
