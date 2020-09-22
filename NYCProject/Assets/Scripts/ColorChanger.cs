using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This means we can attach it to a GameObject
public class ColorChanger : MonoBehaviour 
{

    public Color dogColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<SpriteRenderer>().color = dogColor;
    }
}
