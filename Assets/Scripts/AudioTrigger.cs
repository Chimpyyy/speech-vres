using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void PlayAudio()
    {
        source.PlayOneShot(clip);
    }
}
