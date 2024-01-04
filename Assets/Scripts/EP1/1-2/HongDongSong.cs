using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HongDongSong : MonoBehaviour
{
    public GameObject LightGroupI;
    public GameObject LightGroupII;
    public GameObject LittlePaper;

    public GameObject FishVenderSence;
    public GameObject HongSence;
    public GameObject AnimationSence;

    public Animator BowHeadAnim;
    public Animator PickUpPaperAnim;
    public Animator GivePaperAnim;
    public Animator HongSenceDown;

    public TouchAeraController _TouchAeraController;


   
    public void IfSentThePaper()
    {
        
        StartCoroutine(ReadPaper());
        _TouchAeraController.HideTouchArea();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            StartCoroutine(ReadPaper());
            _TouchAeraController.HideTouchArea();
        }
    }

    private IEnumerator ReadPaper() {
        //yield return new WaitForSeconds(20.0f);
        GivePaperAnim.SetBool("GivePaper", true);

        yield return new
        WaitForSeconds(2.0f);
        BowHeadAnim.SetBool("LookPaper", true);
        PickUpPaperAnim.SetBool("LookPaper", true);

        yield return new
        WaitForSeconds(5.0f);
        HongSenceDown.SetBool("GoDown", true);
        LittlePaper.SetActive(false);

        yield return new
        WaitForSeconds(12.0f);
        LightGroupI.SetActive(false);
        LightGroupII.SetActive(false);

        yield return new
        WaitForSeconds(1.0f);
        FishVenderSence.SetActive(false);
        HongSence.SetActive(false);
        AnimationSence.SetActive(true);

    }

    
}
