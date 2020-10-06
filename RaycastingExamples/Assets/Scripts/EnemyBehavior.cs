using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{

    public float lineOfSightLength = 8.0f;


    public float chargeSpeed = 10f;

    public Rigidbody2D enemyRB;

    private bool hasStartedChargingPlayer = false;

        // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        int layerMask = LayerMask.GetMask("Player");

        RaycastHit2D raycastHit2D = Physics2D.Raycast(transform.position, Vector2.left, lineOfSightLength, layerMask);


        


        if (raycastHit2D.collider != null)  //enemy's line of sight has hit something!
        {

            if (!hasStartedChargingPlayer)
            {
                enemyRB.AddForce(Vector2.left * chargeSpeed, ForceMode2D.Impulse);
                hasStartedChargingPlayer = true;
            }
                

            Debug.DrawRay(transform.position, Vector3.left * lineOfSightLength, Color.green);
        }
        else
        {
            Debug.DrawRay(transform.position, Vector3.left * lineOfSightLength, Color.red);
        }


        

    }
}
