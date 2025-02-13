using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioClip passo;
    public AudioClip pulo;
    public AudioClip ataque;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.clip = passo;
                audioSource.loop = true;
                audioSource.Play();
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.clip = pulo;
            audioSource.PlayOneShot(pulo);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            audioSource.clip = ataque;
            audioSource.PlayOneShot(ataque);
        }
        else
        {
            audioSource.loop = false;
        }

    }
}