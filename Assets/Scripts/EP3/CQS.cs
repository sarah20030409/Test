using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CQS : MonoBehaviour
{
    public GameObject CQSScene;
    public GameObject ChenQuanShui;

    public Animator HeadAnim;
    public Animator HandAnim;
    public Animator SceneBack;

    private float CQSsetActive = 2f;
    public float AfterSecondShave = 0f;
    public float AfterSecondTalk = 0f;
    public float TalkDurationTime = 0f;
    public float SwitchToBoat = 0f;

    void Start()
    {
        StartCoroutine(CQSscript());    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator CQSscript() {
        yield return new
        WaitForSeconds(CQSsetActive);
        ChenQuanShui.SetActive(true);

        yield return new
        WaitForSeconds(AfterSecondShave);
        HeadAnim.SetBool("Change",true);
        HandAnim.SetBool("Change",true);

        yield return new
        WaitForSeconds(AfterSecondTalk);
        HeadAnim.SetBool("Change", false);
        HeadAnim.SetBool("Talk", true);

        yield return new
        WaitForSeconds(TalkDurationTime);
        SceneBack.SetBool("GoBack",true);

        yield return new
        WaitForSeconds(SwitchToBoat);

    }
}
