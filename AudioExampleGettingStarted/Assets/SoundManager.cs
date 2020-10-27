using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{


    public AudioClip playerJump;
    public AudioClip playerMove;
    public AudioClip bgMusic1, bgMusic2;

    public AudioSource bgMusicSource;
    public AudioSource playerSFXSource;

    public static SoundManager Instance;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        if (!bgMusicSource.isPlaying)
        {
            bgMusicSource.loop = true;
            bgMusicSource.clip = bgMusic2;
            bgMusicSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
