using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemyPrefab;

    public GameObject playerObject;

    public float enemySpawnMinimumXPosition = 5;
    public float enemySpawnMaximumXPosition = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            GameObject newEnemy = Instantiate(enemyPrefab);


            float xpos = enemySpawnMinimumXPosition;
            float ypos = enemySpawnMaximumXPosition;

            float enemyXPos = Random.Range(xpos, ypos);

            newEnemy.transform.position = new Vector3(playerObject.transform.position.x + enemyXPos, 0, 0);
        }

    }
}
