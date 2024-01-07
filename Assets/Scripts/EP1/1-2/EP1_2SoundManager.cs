using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class EP1_2SoundManager : MonoBehaviour
{
    public static EP1_2SoundManager instance;
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
    [Header("Text")]
    public ScreenTextManager _ScreenTextManager;

    private void Start()
    {
        instance = this;
        source = GetComponent<AudioSource>();
        _ScreenTextManager.ResetScreenText();
        StartCoroutine(Ep1_2_BeforeGivePaperLines());
    }

    public IEnumerator Ep1_2_BeforeGivePaperLines()
    {
        yield return new WaitForSeconds(Lines1_DelayTime);
        source.PlayOneShot(Lines_1);
        _ScreenTextManager.ScreenTextSet("當時我心裡想我們從地獄來到天堂了嗎?忽然有人提醒我，這是火燒島，他就是謝桂芳");

        yield return new WaitForSeconds(12+Lines2_DelayTime);
        source.PlayOneShot(Lines_2);
        _ScreenTextManager.ScreenTextSet("來這裡隔一個月後肝病去世了...");

        yield return new WaitForSeconds(4f);
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(Lines3_DelayTime);
        source.PlayOneShot(Lines_3);
        _ScreenTextManager.ScreenTextSet("韓戰期間，聽聞每逢大撤退都會採取焦土戰，放火燒集中營，大家都擔心局勢不利政府，我們可能都會被處死...");

        yield return new WaitForSeconds(16 + Lines4_DelayTime);
        source.PlayOneShot(Lines_4);
        _ScreenTextManager.ScreenTextSet("盧兆麟前輩要我出去採買，幫忙記下韓戰的事!我答應他");

        yield return new WaitForSeconds(8f);
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(Lines5_DelayTime);
        source.PlayOneShot(Lines_5);
        _ScreenTextManager.ScreenTextSet("我在市場拿走時局報紙");

        yield return new WaitForSeconds(3f);
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(Lines6_DelayTime);
        source.PlayOneShot(Lines_6);
        _ScreenTextManager.ScreenTextSet("我也將紙條遞給了洪炯松前輩");

        yield return new WaitForSeconds(4f);
        _ScreenTextManager.ScreenTextSet("(把紙條遞給洪炯松前輩)");

    }

    public IEnumerator Ep1_2_AfterGivePaperLines()
    {
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(Lines7_DelayTime);
        source.PlayOneShot(Lines_7);
        _ScreenTextManager.ScreenTextSet("有一次我在倉庫外把紙條遞給他，後來...");

        yield return new WaitForSeconds(6f);
        _ScreenTextManager.ResetScreenText();

        yield return new WaitForSeconds(Lines8_DelayTime);
        source.PlayOneShot(Lines_8);
        _ScreenTextManager.ScreenTextSet("洪炯松你在看甚麼?!不要跑!!!");

        yield return new WaitForSeconds(6+Lines9_DelayTime);
        source.PlayOneShot(Lines_9);
        _ScreenTextManager.ScreenTextSet("洪炯松被被送回台北，從此離開第三中隊");

        yield return new WaitForSeconds(5f);
        _ScreenTextManager.ResetScreenText();




    }

    public void PlayAfterGivePaper()
    {
        StartCoroutine(Ep1_2_AfterGivePaperLines());
    }
}
