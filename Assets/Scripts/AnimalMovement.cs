using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnimalMovement : MonoBehaviour
{

    public float speed = 1.0f;

    public KeyCode up, down, left, right;

    public TextMeshProUGUI textLabel;

    public string NoiseToMake;

    public Rigidbody2D rigidbody;
    


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        
        if(Input.GetKey(right))
        {

            rigidbody.AddForce(Vector2.right);

        } else if (Input.GetKey(left))
        {
            rigidbody.AddForce(Vector2.left);
        
          } else if (Input.GetKey(up))
        {
            rigidbody.AddForce(Vector2.up);
        
        } else if (Input.GetKey(down))
        {
            rigidbody.AddForce(Vector2.down);
        } 

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(right))
        {
           //transform.Translate(Vector3.right * speed);
           GetComponent<Animator>().Play("walk_right");


        } else if (Input.GetKey(left))
        {
           // transform.Translate(Vector3.left * speed);
            GetComponent<Animator>().Play("walk_left");

        } else if (Input.GetKey(down))
        {
           // transform.Translate(Vector3.down * speed);
            GetComponent<Animator>().Play("walk_down");
        }
        else if (Input.GetKey(up))
        {
           // transform.Translate(Vector3.up * speed);
            GetComponent<Animator>().Play("walk_up");
        } else
        {
            GetComponent<Animator>().Play("idle");
        }

        if(Input.GetKeyDown(up) || Input.GetKeyDown(down) || Input.GetKeyDown(left) || Input.GetKeyDown(right))
        {
            textLabel.text = "";
        }

        //set the position of the textLabel to the same as the position of THIS animal
        textLabel.transform.position = transform.position;

    }

    public void PressButtonToMakeNoise()
    {
        textLabel.text = NoiseToMake;
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        PressButtonToMakeNoise();
    }

}
