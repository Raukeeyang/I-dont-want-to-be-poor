using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Light : MonoBehaviour
{
    public Pathfinding path;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player") path.GetComponent<Pathfinding>().enemy=true;
        if (collision.gameObject.tag == "Player") path.GetComponent<Pathfinding>().speed=12;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") path.GetComponent<Pathfinding>().lost = true;
        if (collision.gameObject.tag == "Player") path.GetComponent<Pathfinding>().speed = 8;
    }
}
