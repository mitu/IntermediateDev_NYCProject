using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogMovement : MonoBehaviour
{

    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
           transform.Translate(Vector3.right * speed);
           GetComponent<Animator>().Play("walk_right");


        } else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed);
            GetComponent<Animator>().Play("walk_left");

        } else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed);
            GetComponent<Animator>().Play("walk_down");
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed);
            GetComponent<Animator>().Play("walk_up");
        } else
        {
            GetComponent<Animator>().Play("idle");
        }



    }
}
