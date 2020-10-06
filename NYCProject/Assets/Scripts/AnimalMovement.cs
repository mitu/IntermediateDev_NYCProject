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

    

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {

        if (GameManager.gmSingleton != null)
        {
            Debug.Log("GameManager is ready to use.");
            rigidbody = GetComponent<Rigidbody2D>();

        }
    }


    private void FixedUpdate()
    {

            if (Input.GetKey(right))
            {

                //rigidbody.AddForce(Vector2.right * speed);
                rigidbody.velocity = new Vector2(1 * speed, rigidbody.velocity.y > -4.0f ? rigidbody.velocity.y : -4.0f);
                               Debug.Log("Move right");

            }
            else if (Input.GetKey(left))
            {
                rigidbody.velocity = new Vector2(-1 * speed, rigidbody.velocity.y > -4.0f ? rigidbody.velocity.y : -4.0f);

                Debug.Log("Move left");
            }
            else if (Input.GetKey(up))
            {
                rigidbody.AddForce(Vector2.up * speed);

            }
            else if (Input.GetKey(down))
            {
                rigidbody.AddForce(Vector2.down * speed);
            }

            else
            {
                rigidbody.velocity = Vector2.zero;
            }

    }

    // Update is called once per frame
    void Update()
    {


        if (!GameManager.gmSingleton.hasGameStarted)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameManager.gmSingleton.hasGameStarted = true;
            }
        }

        if (GameManager.gmSingleton.hasGameStarted)
        {

            if (Input.GetKey(right))
            {
                //transform.Translate(Vector3.right * speed);
                GetComponent<Animator>().Play("walk_right");


            }
            else if (Input.GetKey(left))
            {
                // transform.Translate(Vector3.left * speed);
                GetComponent<Animator>().Play("walk_left");

            }
            else if (Input.GetKey(down))
            {
                // transform.Translate(Vector3.down * speed);
                GetComponent<Animator>().Play("walk_down");
            }
            else if (Input.GetKey(up))
            {
                // transform.Translate(Vector3.up * speed);
                GetComponent<Animator>().Play("walk_up");
            }
            else
            {
                GetComponent<Animator>().Play("idle");
            }

            if (Input.GetKeyDown(up) || Input.GetKeyDown(down) || Input.GetKeyDown(left) || Input.GetKeyDown(right))
            {
                textLabel.text = "";
            }

            //set the position of the textLabel to the same as the position of THIS animal
            textLabel.transform.position = transform.position;
        }

    }

    public void PressButtonToMakeNoise()
    {
        textLabel.text = NoiseToMake;
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
    
        Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);
        PressButtonToMakeNoise();
        score++;

        GameManager.gmSingleton.noOfCollisions++;


    }

}
