using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtSound : MonoBehaviour
{
    public static bool PlaySoundHurt = false;
    public AudioSource TakeDamage;
    void Start()
    {
        TakeDamage = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if(PlaySoundHurt == true)
        {
            TakeDamage.Play();
            PlaySoundHurt = false;
        }
    }
}
