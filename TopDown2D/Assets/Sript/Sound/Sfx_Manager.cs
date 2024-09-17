using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Sfx_Manager : MonoBehaviour 
{
    public static Sfx_Manager Instance; // nur zum Singelton wenn nur 1 in der scene !!
    [SerializeField] private AudioSource soundFxObject;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;   
        }
    }

    public void PlaySoundFxClip(AudioClip audio, Transform spawnTransform, float volume)
    {
        AudioSource audioSource = Instantiate(soundFxObject, spawnTransform.position, Quaternion.identity);

        audioSource.clip = audio;

        audioSource.volume = volume; 

        audioSource.Play();


        float clipLength = audioSource.clip.length;

        Destroy(audioSource, clipLength);




    }
}
