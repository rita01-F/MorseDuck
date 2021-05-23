using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Music : MonoBehaviour
{
    private static Music instance = null;
    private AudioSource MyAudio;

    private void Awake()
    { 
        if (instance == null)
        { 
            instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        if (instance == this) return;
        Destroy(gameObject);
    }

    void Start()
    {
        MyAudio = GetComponent<AudioSource>();
        MyAudio.Play();
    }
}
