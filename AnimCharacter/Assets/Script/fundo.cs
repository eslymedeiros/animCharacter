using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fundo : MonoBehaviour
{
    public AudioClip fundoF;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSource.clip = fundoF;
        audioSource.loop = true;
        audioSource.Play();
    }
}