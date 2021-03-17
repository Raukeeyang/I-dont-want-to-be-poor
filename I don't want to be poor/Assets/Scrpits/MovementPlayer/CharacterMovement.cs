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

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        if (moving == true)
        {
            movementt();
        }
        movementCheck();

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Horizontal", movement.x);

        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    //Movement player
    public void SetMoving(bool val)
    {
        moving = val;
    }

    void movementt()
    {
        if(Input.GetKey(KeyCode.W))
            {
            //  transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
           // transform.Translate(movement * speed * Time.deltaTime, Space.World);
            
            moving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //  transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
           // transform.Translate(movement * speed * Time.deltaTime, Space.World);
            
            moving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            // transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
           // transform.Translate(movement * speed * Time.deltaTime, Space.World);
            
            moving = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //  transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
           // transform.Translate(movement * speed * Time.deltaTime, Space.World);
            
            moving = true;
        }

        transform.Translate(movement * speed * Time.deltaTime);

        
        
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
