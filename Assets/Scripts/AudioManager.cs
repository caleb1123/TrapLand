using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Clip;
    // Static singleton property.
    public static AudioManager Instance { get; private set; }
    public void Awake()
    {
        // Save a reference to the AudioManager component as our //singleton instance.
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Instance method, this method can be accessed through the //singleton instance
    public void PlayAudio(AudioSource clip)
    {
        clip.Play();
    }


}
