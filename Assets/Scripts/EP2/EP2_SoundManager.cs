using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class EP2_SoundManager : MonoBehaviour
{
    public static EP2_SoundManager instance;
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
    public AudioClip Lines_10;
    public AudioClip Lines_11;
    public AudioClip Lines_12;
    public AudioClip Lines_13;
    
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
    public float Lines10_DelayTime;
    public float Lines11_DelayTime;
    public float Lines12_DelayTime;
    public float Lines13_DelayTime;
    [Header("Sinning")]
    [Header("BGM")]
    public AudioSource Song;
    private bool CloseBGM = false;
    public float BGMVolume;
    public float VolumeDecreaseSpeed;
    [Header("Text")]
    public ScreenTextManager _ScreenTextManager;
    private void Start()
    {
        instance = this;
        source = GetComponent<AudioSource>();
        _ScreenTextManager.ResetScreenText();
        StartCoroutine(Ep2_Lines());
        CloseBGM = false;
    }
    private void Update()
    {
        if (CloseBGM)
        {
            if (BGMVolume >= 0)
            {
                BGMVolume -= Time.deltaTime * VolumeDecreaseSpeed;
                Song.volume = BGMVolume;
            }
        }
        else
        {
            Song.volume = BGMVolume;
        }
    }
    public IEnumerator Ep2_Lines()
    {
        yield return new WaitForSeconds(Lines1_DelayTime);
        source.PlayOneShot(Lines_1);
        _ScreenTextManager.ScreenTextSet("那時候很常看到楊逵前輩跑步，這麼令人欽佩的文學家，也要遭受這種苦役...");

        yield return new WaitForSeconds(11 + Lines2_DelayTime);
        source.PlayOneShot(Lines_2);
        _ScreenTextManager.ScreenTextSet("我告訴我自己像這樣了不起的人都可以忍受...我20歲的小夥子受一點苦算甚麼呢...");

        yield return new WaitForSeconds(10f);
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(Lines3_DelayTime);
        source.PlayOneShot(Lines_3);
        

        yield return new WaitForSeconds(7+Lines4_DelayTime);
        source.PlayOneShot(Lines_4);
        _ScreenTextManager.ScreenTextSet("我跟施秋霖先生一起在海邊唱歌");
        Song.Play();
        StartCoroutine(SingSong());

        yield return new WaitForSeconds(4f);
        _ScreenTextManager.ResetScreenText();
        

        yield return new WaitForSeconds(Lines5_DelayTime);
        source.PlayOneShot(Lines_5);

        yield return new WaitForSeconds(2+Lines6_DelayTime);
        source.PlayOneShot(Lines_6);

        yield return new WaitForSeconds(2+Lines7_DelayTime);
        source.PlayOneShot(Lines_7); 
        _ScreenTextManager.ScreenTextSet("當我知道炳紅他被關禁閉了");

        yield return new WaitForSeconds(3 + Lines8_DelayTime);
        source.PlayOneShot(Lines_8);
        _ScreenTextManager.ScreenTextSet("我慢慢接近碉堡把糖果放進窗口中給炳紅");

        yield return new WaitForSeconds(5 + Lines9_DelayTime);
        source.PlayOneShot(Lines_9);
        _ScreenTextManager.ScreenTextSet("他卻說他想要水...");

        yield return new WaitForSeconds(3 + Lines10_DelayTime);
        source.PlayOneShot(Lines_10);
        _ScreenTextManager.ScreenTextSet("那時候我想幫助蔡炳紅更多...但我無能為力");

        yield return new WaitForSeconds(5f);
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(Lines11_DelayTime);
        source.PlayOneShot(Lines_11);

        yield return new WaitForSeconds(4+Lines12_DelayTime);
        source.PlayOneShot(Lines_12);
        _ScreenTextManager.ScreenTextSet("各位新生！你們要知道，平時就要遵守營區規矩！被送回台灣的同伴們");

        yield return new WaitForSeconds(7f);
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(Lines13_DelayTime);
        source.PlayOneShot(Lines_13);
        
    }
    public IEnumerator SingSong()
    {
        yield return new WaitForSeconds(5);
        CloseBGM = true;
    }
}
