using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Ep1_1SoundManager : MonoBehaviour
{
    public static Ep1_1SoundManager instance;
    private AudioSource source;

    [Header("Lines")]
    public AudioClip Lines_1;
    [Header("Lines_Delay")]
    public float Lines1_DelayTime;
    [Header("Text")]
    public ScreenTextManager _ScreenTextManager;


    private void Start()
    {
        source= GetComponent<AudioSource>();
        _ScreenTextManager.ScreenTextSet("(海浪聲)");
        StartCoroutine(Ep1_1Lines());
    }
   
    public IEnumerator Ep1_1Lines()
    {
        yield return new WaitForSeconds(Lines1_DelayTime);
        _ScreenTextManager.ScreenTextSet("我們在哪裡?會不會開到海中央把我們丟下海?");
        source.PlayOneShot(Lines_1);
        yield return new WaitForSeconds(5);
        _ScreenTextManager.ResetScreenText();
    }

}
