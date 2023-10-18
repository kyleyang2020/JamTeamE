using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // singletons are broken, search up how it works
    // allows other scripts to access it by using SoundManager.instance.PlaySound() or whatever
    public static SoundManager instance { get; private set; }
    private AudioSource soundSource; // access audiosource component

    // assigning variables referenced above
    private void Awake()
    {
        instance = this;
        soundSource = GetComponent<AudioSource>();
    }

    // plays given sound once
    public void PlaySound(AudioClip _sound)
    {
        soundSource.PlayOneShot(_sound);
    }
}
