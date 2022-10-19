using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MusicPlayer : MonoBehaviour
{
    private AudioSource source;
    
    private void Awake() 
    {
        source = GetComponent<AudioSource>();
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");

        if (musicObj.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start() 
    {
        if (!AudioListener.pause && !source.isPlaying)
        {
            source.Play();
        }
        else
        {
            AudioListener.pause = true;
        }
    }
}
