using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSummon : MonoBehaviour
{
    [Header("Audio")]

    public AudioClip spawnSound;

    [Header("Items")]

    public List<GameObject> items;

    public void OnSummon(string[] values)
    {
        int i = 0;
        if (values[0] == "get")
        {
            if (values[1] == "c-collar")
            {
                i = 0;
            }
            else if (values[1] == "flashlight")
            {
                i = 1;
            }
        }
        else
            print("Not Working");

        AudioPlay();
        items[i].SetActive(true);
    }

    public void OnDeSummon(string[] values)
    {
        int i = 0;
        if (values[0] == "return")
        {
            if (values[1] == "c-collar")
            {
                i = 0;
            }
            else if (values[1] == "flashlight")
            {
                i = 1;
            }
        }
        else
            print("Not Working");

        AudioPlay();
        items[i].SetActive(false);
    }

    private void AudioPlay()
    {
        if (spawnSound != null)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource == null)
            {
                audioSource = gameObject.AddComponent<AudioSource>();
            }
            audioSource.clip = spawnSound;
            audioSource.Play();
        }
    }
}
