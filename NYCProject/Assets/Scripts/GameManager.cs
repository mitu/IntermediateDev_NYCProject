using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int score = 0;
    public bool hasGameStarted = false;
    public int noOfCollisions = 0;


    public static GameManager gmSingleton;


    void Awake()
    {
        gmSingleton = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("No. of collisions " + noOfCollisions);
    }
}
