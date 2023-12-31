using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource source;
    [SerializeField] SoundSO soundSO;

    
    private void Awake()
    {
        instance = this;
        source.PlayOneShot(soundSO.test);
        source.PlayOneShot(soundSO.test1);
        
    }

}
