using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Footstep : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] concreteAudioClips;
    [SerializeField]
    private AudioClip[] dirtAudioClips;
    [SerializeField]
    private AudioClip[] metalAudioClips;
    [SerializeField]
    private AudioClip[] sandAudioClips;
    [SerializeField]
    private AudioClip[] woodAudioClips;

    private AudioSource mAudioSource;

    private void Awake()
    {
        mAudioSource = GetComponent<AudioSource>();
    }
    private void Step() //Funtion is called during an event during the animation of walking
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 3))
        {

            if (hit.transform.CompareTag("Concrete"))
            {
                int index = Random.Range(0, concreteAudioClips.Length);
                AudioClip clip = concreteAudioClips[index];
                mAudioSource.PlayOneShot(clip);
            }
            if (hit.transform.CompareTag("Dirt"))
            {
                int index = Random.Range(0, dirtAudioClips.Length);
                AudioClip clip = dirtAudioClips[index];
                mAudioSource.PlayOneShot(clip);
            }
            if (hit.transform.CompareTag("Metal"))
            {
                int index = Random.Range(0, metalAudioClips.Length);
                AudioClip clip = metalAudioClips[index];
                mAudioSource.PlayOneShot(clip);
            }
            if (hit.transform.CompareTag("Sand"))
            {
                int index = Random.Range(0, sandAudioClips.Length);
                AudioClip clip = sandAudioClips[index];
                mAudioSource.PlayOneShot(clip);
            }
            if (hit.transform.CompareTag("Wood"))
            {
                int index = Random.Range(0, woodAudioClips.Length);
                AudioClip clip = woodAudioClips[index];
                mAudioSource.PlayOneShot(clip);
            }
        }
        //CheckTerrain();
        //AudioClip clip = GetRandomClip(dirtAudioClips);
        //mAudioSource.PlayOneShot(clip);
    }
    

    //private AudioClip GetRandomClip(AudioClip[] a)
    //{
    //    int index = Random.Range(0, a.Length);
    //    return a[index];
    //}
    //private AudioClip CheckTerrain()
    //{
    //    RaycastHit hit;
    //    if (Physics.Raycast(transform.position, Vector3.down, out hit, 3))
    //    {

    //        if (hit.transform.CompareTag("Concrete"))
    //        {
    //            int index = Random.Range(0, concreteAudioClips.Length);
    //            return concreteAudioClips[index];
    //        }
    //        if (hit.transform.CompareTag("Dirt"))
    //        {
    //            int index = Random.Range(0, dirtAudioClips.Length);
    //            return dirtAudioClips[index];
    //        }
    //        if (hit.transform.CompareTag("Metal"))
    //        {
    //            int index = Random.Range(0, metalAudioClips.Length);
    //            return metalAudioClips[index];
    //        }
    //        if (hit.transform.CompareTag("Sand"))
    //        {
    //            int index = Random.Range(0, sandAudioClips.Length);
    //            return sandAudioClips[index];
    //        }
    //        if (hit.transform.CompareTag("Wood"))
    //        {
    //            int index = Random.Range(0, woodAudioClips.Length);
    //            return woodAudioClips[index];
    //        }
    //    }
    //    else
    //    {
    //        int index = Random.Range(0, woodAudioClips.Length);
    //        return woodAudioClips[index];
    //    }
    //}
}
