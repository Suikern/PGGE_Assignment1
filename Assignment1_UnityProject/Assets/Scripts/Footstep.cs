using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] mAudioClips;

    private AudioSource mAudioSource;
    private void Awake()
    {
        mAudioSource = GetComponent<AudioSource>();
    }
    private void Step() //Funtion is called during an event during the animation of walking
    {
        AudioClip clip = GetRandomClip();
        mAudioSource.PlayOneShot(clip);
    }
    

    private AudioClip GetRandomClip()
    {
        return mAudioClips[Random.Range(0, mAudioClips.Length)];
    }
}
