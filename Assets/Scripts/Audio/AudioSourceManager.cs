using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceManager : MonoBehaviour
{  
    private AudioSource source;
    
    private void Awake() 
    {
        source = GetComponent<AudioSource>();
    }
    
    private void Start() 
    {
        if (!AudioListener.pause == true && !source.isPlaying)
        {
            source.Play();
        }
        else
        {
            AudioListener.pause = true;
        }
    }
}
