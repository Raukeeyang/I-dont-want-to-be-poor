using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public Transform[] HotSposts;
    private int Spot;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        Spot = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, HotSposts[Spot].position, speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, HotSposts[Spot].position)<0.1)
        {
            Spot++;
           // transform.LookAt(HotSposts[Spot], Vector3.up);
            
            Debug.Log(Spot);

            if (Spot>=HotSposts.Length)
            {
                Spot = 0;
            }
            transform.right = HotSposts[Spot].position - transform.position;
        }
    }
}
