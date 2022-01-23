using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
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
        int index = Random.Range(0, mAudioClips.Length);
        return mAudioClips[index];
    }
}
