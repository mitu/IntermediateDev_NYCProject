using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    Rigidbody2D playerRB;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRB.AddForce(Vector2.up * 20f, ForceMode2D.Impulse);
            playerAudio.clip = SoundManager.Instance.playerJump;
            playerAudio.loop = false;
            playerAudio.volume = 0.1f;
            playerAudio.volume = 1.0f;
            playerAudio.Play();
            //playerAudio.PlayOneShot(SoundManager.Instance.playerJump);
        }

        float horizontalInput = Input.GetAxis("Horizontal");

        playerRB.velocity = new Vector2(horizontalInput * 20f, 0);

        if (playerRB.velocity != Vector2.zero) 
        {
            if (!playerAudio.isPlaying)
            {
                playerAudio.clip = SoundManager.Instance.playerMove;
                playerAudio.loop = true;
                playerAudio.Play();
            }
        }

    }
}
