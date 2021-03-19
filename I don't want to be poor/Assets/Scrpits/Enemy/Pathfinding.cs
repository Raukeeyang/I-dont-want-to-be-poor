using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinding : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float startWaitTime;

    public bool enemy;
    public bool lost;
    public float timer;
    public Transform player;

    public Transform[] HotSposts;
    private int Spot;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        Spot = 0;
        enemy = false;
        lost = false;
        timer = 0;
        
    }
    private void Update()
    {
        if (enemy == false)
        {
            Path(HotSposts[Spot]);
        }
        else
        {
            Path(player);
        }
        if (lost)
        {
            timer += Time.deltaTime;

            if (timer>=1.5f)
            {
                enemy = false;
                timer = 0;
                lost = false;
            }
        }
        

    }

    // Update is called once per frame
    public void Path(Transform point)
    {
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);

        animator.SetFloat("Vertical", point.position.y);
        animator.SetFloat("Vertical", - point.position.y);
        animator.SetFloat("Horizontal", point.position.x);
        animator.SetFloat("Horizontal", - point.position.x);

        if (Vector3.Distance(transform.position, point.position)<0.1)
        {
            Spot++;
           // transform.LookAt(HotSposts[Spot], Vector3.up);
            
            Debug.Log(Spot);

            if (Spot>=HotSposts.Length)
            {
                Spot = 0;
            }
            
        }
        transform.right = point.position - transform.position;
    }


}
