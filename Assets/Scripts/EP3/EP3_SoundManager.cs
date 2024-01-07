using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EP3_SoundManager : MonoBehaviour
{
    public static EP3_SoundManager instance;
    private AudioSource Lines_source;


    
    [Header("Lines")]
    public AudioClip Lines_1;
    public AudioClip Lines_2;
    public AudioClip Lines_3;
    [Header("Lines_Delay")]
    public float Lines1_DelayTime;
    public float Lines2_DelayTime;
    public float Lines3_DelayTime;
    [Header("Text")]
    public ScreenTextManager _ScreenTextManager;
    public float Text2_DelayTime;
    public float Text3_DelayTime;
    public float Text4_DelayTime;
    [Header("BGM")]
    public AudioSource BGM_source;
    private bool CloseBGM = false;
    public float BGMVolume;
    public float VolumeDecreaseSpeed;




    private void Start()
    {
        Lines_source = GetComponent<AudioSource>();
        _ScreenTextManager.ResetScreenText();
        StartCoroutine(Ep3_LinesPart1()); 
        CloseBGM = false;
    }
    private void Update()
    {
        if (CloseBGM)
        {
            if (BGMVolume >= 0)
            {
                BGMVolume -= Time.deltaTime * VolumeDecreaseSpeed;
                BGM_source.volume = BGMVolume;
            }
        }
        else
        {
            BGM_source.volume = BGMVolume;
        }
    }
    public IEnumerator Ep3_LinesPart1()
    {
        yield return new WaitForSeconds(Lines1_DelayTime);
        _ScreenTextManager.ScreenTextSet("我離開家鄉是20歲的時候快將近八年了");
        Lines_source.PlayOneShot(Lines_1);

        yield return new WaitForSeconds(6+Text2_DelayTime);
        _ScreenTextManager.ScreenTextSet("近八年了...「人生有幾個八年？」");

        yield return new WaitForSeconds(6+Text3_DelayTime);
        _ScreenTextManager.ScreenTextSet("對一般人這簡直不堪想像的可怕");

        yield return new WaitForSeconds(5.5f + Text4_DelayTime);
        _ScreenTextManager.ScreenTextSet("就是我自己，當初也幾乎是癱瘓了，不是嗎？");

        yield return new WaitForSeconds(6 + Text4_DelayTime);
        _ScreenTextManager.ScreenTextSet("人生的黃金時期盡付諸東流，再也無可挽回…");

        yield return new WaitForSeconds(7);
        _ScreenTextManager.ResetScreenText();
        CloseBGM = true;
        StartCoroutine(Ep3_LinesPart2());


    }
    public IEnumerator Ep3_LinesPart2()
    {
        yield return new WaitForSeconds(Lines2_DelayTime);
        Lines_source.PlayOneShot(Lines_2);
        _ScreenTextManager.ScreenTextSet("蔡桑！出來幫我剃頭！");

        yield return new WaitForSeconds(3.5f);
        _ScreenTextManager.ScreenTextSet("保單收到了喔？");

        yield return new WaitForSeconds(3.5f);
        _ScreenTextManager.ScreenTextSet("我大姐和她朋友替我做保");

        yield return new WaitForSeconds(4f);
        _ScreenTextManager.ScreenTextSet("你親戚還真勇敢！蔡桑要離開，不能說再見，若是出去，不要回頭看！");

        yield return new WaitForSeconds(8.5f);
        _ScreenTextManager.ScreenTextSet("水泉師傅，不要這麼說，一定會再見面的");

        yield return new WaitForSeconds(5f);
        _ScreenTextManager.ScreenTextSet("像我這種無期的喔！是真的沒有辦法再見面囉！");

        yield return new WaitForSeconds(4f+ Lines3_DelayTime);
        _ScreenTextManager.ScreenTextSet("你現在頭髮可以留長了，就不幫你嚕頭囉！");
        Lines_source.PlayOneShot(Lines_3);

        yield return new WaitForSeconds(3);
        _ScreenTextManager.ResetScreenText();


    }


}
