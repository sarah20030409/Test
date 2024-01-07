using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class PorolgueSoundManager : MonoBehaviour
{
    public static PorolgueSoundManager instance;
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
  
    [Header("Lines_Delay")]
    public float Lines1_DelayTime;
    public float Lines2_DelayTime;
    public float Lines3_DelayTime;
    public float Lines4_DelayTime;
    public float Lines5_DelayTime;
    public float Lines6_DelayTime;
    public float Lines7_DelayTime;
    public float Lines8_DelayTime;

    [Header("SoundEffect")]
    public AudioClip FingerPrintSoundEffect;
    public AudioClip ScreamingSoundEffect;
    public float ScreamingSoundEffect_DelayTime;

    [Header("Text")]
    public ScreenTextManager _ScreenTextManager;





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
        _ScreenTextManager.ScreenTextSet("這一天，我的肉身終於離開了火燒島，但我的夥伴卻永遠困在這了...");

        yield return new WaitForSeconds(10+Lines2_DelayTime);
        source.PlayOneShot(Lines_2);
        _ScreenTextManager.ScreenTextSet("你看你只要輕輕蓋個手印，過兩天就放你回去了啦!");

        yield return new WaitForSeconds(5);
        _ScreenTextManager.ScreenTextSet("(使用搖桿側鍵蓋手印)");


    }
    public IEnumerator AfterFingerPrintLinesPart()
    {
        float CurrentDelay = 0;
        _ScreenTextManager.ResetScreenText();
        yield return new WaitForSeconds(Lines3_DelayTime);
        source.PlayOneShot(Lines_3);
        CurrentDelay += Lines3_DelayTime;


        yield return new WaitForSeconds(CurrentDelay + ScreamingSoundEffect_DelayTime);
        _ScreenTextManager.ScreenTextSet("(哀號聲)");
        ScreamingSoundEffectSound();
        CurrentDelay += ScreamingSoundEffect_DelayTime;

        yield return new WaitForSeconds(CurrentDelay + Lines4_DelayTime);
        source.PlayOneShot(Lines_4);
        _ScreenTextManager.ScreenTextSet("來這裡之前，我曾經在看守所裡受到這樣的拜託");
        CurrentDelay += Lines4_DelayTime;

        yield return new WaitForSeconds(CurrentDelay + Lines5_DelayTime);
        source.PlayOneShot(Lines_5);
        _ScreenTextManager.ScreenTextSet("如果我回不去了，請幫我把這封信送回家吧");
        CurrentDelay += Lines5_DelayTime;

        yield return new WaitForSeconds(9);
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(CurrentDelay + Lines6_DelayTime);
        source.PlayOneShot(Lines_6);
        _ScreenTextManager.ScreenTextSet("二哥！請幫我把這封信送去這個住址");
        CurrentDelay += Lines5_DelayTime;

        yield return new WaitForSeconds(6);
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(CurrentDelay + Lines7_DelayTime);
        source.PlayOneShot(Lines_7);
        _ScreenTextManager.ScreenTextSet("焜霖阿...你著愛好好保重...身體顧予好...");

        yield return new WaitForSeconds(7 + Lines8_DelayTime);
        source.PlayOneShot(Lines_8);
        yield return new WaitForSeconds(1);
        _ScreenTextManager.ScreenTextSet("阿爸...");

        yield return new WaitForSeconds(3);
        _ScreenTextManager.ResetScreenText();

    }
   
    public void PlayAfterFingerPrintLines()
    {
        StartCoroutine(AfterFingerPrintLinesPart());
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
