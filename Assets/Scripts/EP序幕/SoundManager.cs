using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private AudioSource source;

    [Header("Lines")]
    public AudioClip Lines_1;
    public AudioClip Lines_2;
    public AudioClip Lines_3;
    public AudioClip Lines_4;
    public AudioClip Lines_5;
    public AudioClip Lines_6;
    public AudioClip Lines_7;
    public AudioClip Lines_8;
    public AudioClip Lines_9;
    [Header("Lines_Delay")]
    public float Lines1_DelayTime;
    public float Lines2_DelayTime;
    public float Lines3_DelayTime;
    public float Lines4_DelayTime;
    public float Lines5_DelayTime;
    public float Lines6_DelayTime;
    public float Lines7_DelayTime;
    public float Lines8_DelayTime;
    public float Lines9_DelayTime;
    [Header("SoundEffect")]
    public AudioClip FingerPrintSoundEffect;
    public AudioClip ScreamingSoundEffect;
    public float ScreamingSoundEffect_DelayTime;
    public AudioClip OceanSoundEffect;





    private void Awake()
    {
        instance = this;
        source = GetComponent<AudioSource>();
            
        StartCoroutine(BeforeFingerPrintLines());
        
    }
    public IEnumerator BeforeFingerPrintLines()
    {

        yield return new WaitForSeconds(Lines1_DelayTime);
        source.PlayOneShot(Lines_1);

        yield return new WaitForSeconds(10+Lines2_DelayTime);
        source.PlayOneShot(Lines_2);
        

    }
    public IEnumerator AfterFingerPrintLinesPart1()
    {
        float CurrentDelay = 0;

        yield return new WaitForSeconds(Lines3_DelayTime);
        source.PlayOneShot(Lines_3);
        CurrentDelay += Lines3_DelayTime;

        yield return new WaitForSeconds(CurrentDelay + ScreamingSoundEffect_DelayTime);
        ScreamingSoundEffectSound();
        CurrentDelay += ScreamingSoundEffect_DelayTime;

        yield return new WaitForSeconds(CurrentDelay + Lines4_DelayTime);
        source.PlayOneShot(Lines_4);
        CurrentDelay += Lines4_DelayTime;

        yield return new WaitForSeconds(CurrentDelay + Lines5_DelayTime);
        source.PlayOneShot(Lines_5);
        Debug.Log("5");
        CurrentDelay += Lines5_DelayTime;

        yield return new WaitForSeconds(CurrentDelay + Lines6_DelayTime);
        source.PlayOneShot(Lines_6);
        Debug.Log("6");
        CurrentDelay += Lines6_DelayTime;
        StartCoroutine(AfterFingerPrintLinesPart2());



    }
    public IEnumerator AfterFingerPrintLinesPart2()
    {
        float CurrentDelay = 0;
        yield return new WaitForSeconds(Lines7_DelayTime);
        source.PlayOneShot(Lines_7);
        Debug.Log("7");
        CurrentDelay += Lines7_DelayTime;
        
        yield return new WaitForSeconds( 7 + Lines8_DelayTime);
        source.PlayOneShot(Lines_8);
        Debug.Log("8");
        CurrentDelay += Lines8_DelayTime;
    }
    public void PlayAfterFingerPrintLines()
    {
        StartCoroutine(AfterFingerPrintLinesPart1());
    }
    public void PlayFingerPrintSound()
    {
        source.PlayOneShot(FingerPrintSoundEffect);
    }
    public void ScreamingSoundEffectSound()
    {
        source.PlayOneShot(ScreamingSoundEffect);
    }


}
