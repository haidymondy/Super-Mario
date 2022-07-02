using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{


    public int speed = 5;
    public float direction=0;
    public Animator animator;
    public Animator jump;
    public int jumpspeed = 10;
    public float jumpdirection = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>();
       

    }

    // Update is called once per frame
    void Update()
    {
                 //x axis move & rotate
        direction = Input.GetAxis("Horizontal");
        transform.position += new Vector3(direction, 0, 0) * speed * Time.deltaTime;
        if(direction == 0)
        {
            animator.SetBool("run", false);
        }
        else if (direction > 0)
        {
            animator.SetBool("run", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        else
        {
            animator.SetBool("run", true);
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

             //jumpman
        jumpdirection = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, jumpdirection, 0) * jumpspeed * Time.deltaTime;
        if (jumpdirection > 0)
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }

        //OnCollisionEnter2D();

        //destroy fruits
/*
          void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "cherry")
            {
                //DestroyObject(collision.gameObject);
                Destroy(collision.gameObject);
                Debug.Log("trdhghv");
            }

            if (collision.gameObject.tag == "pineapple")
            {
                Destroy(collision.gameObject);

                //DestroyObject(collision.gameObject);
            }

        }*/

    }
    //fruits&trapps
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "cherry")
        {
            DestroyObject(collision.gameObject);
            score.scoreval += 1 ;
        }

        if (collision.gameObject.tag == "pineapple")
        {
            DestroyObject(collision.gameObject);
            score.scoreval += 1;
        }

        if (collision.gameObject.tag == "Off")
        {
           // DestroyObject(collision.gameObject);
            score.scoreval -= 1;
        }
        if (collision.gameObject.tag == "fire")
        {
            // DestroyObject(collision.gameObject);
            score.scoreval -= 1;
        }
       

    }
}
