using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayAudioClip : MonoBehaviour
{

    public AudioClip clip;
    public AudioSource audioSource;


    void start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<audioSource>();
        }
    }

    public void OnPlayAudio(InputAction.ContextCallback context)
    {
       if (context.ReadValue==1)
        {
            Play();
        }
    }

    IEnumerator Play()
    {
        audioSource.clip = clip;
        audioSource.PlayOneShot();
    }
    
}
