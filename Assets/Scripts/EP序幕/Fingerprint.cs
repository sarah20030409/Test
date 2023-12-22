using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fingerprint: MonoBehaviour
{
    public Animator BlinkAnim;
    public GameObject officerState; //官員
    public GameObject secondTitle;//第二個標題

    public Animator paperUpAnim;
    public float MurMurTime = 10f;
    public static bool getFingerPrint = false; //蓋手印判斷 

    public GameObject RedFinger;


    //private bool isCoroutineRunning = false;
    public float doBlink = 3f;
    void Start()
    {

    }


    void Update()
    {
        //方法二 - 協成(顏維婷寫互動後觸發條件後把 getFingerPrint = true)
        StartCoroutine(BlinkAndDisappear());


        /*方法一
        Invoke("BlinkEye", doBlink);
        Invoke("officerDisappear", doBlink+3.0f);*/
        Debug.Log("state:" + getFingerPrint);
    }

    private IEnumerator BlinkAndDisappear()
    {
        yield return new WaitForSeconds(MurMurTime);
        paperUpAnim.SetBool("Up", true);

        yield return new WaitForSeconds(MurMurTime + 1f);
        RedFinger.SetActive(true);

        if (getFingerPrint) { 
        yield return new WaitForSeconds(doBlink);
        BlinkAnim.SetBool("Blink", true); // 'doBlink'秒後，眨眼

        yield return new WaitForSeconds(1f);
        officerState.SetActive(false);
        secondTitle.SetActive(true);
        }
        

    }

    /*public void BlinkEye()
    {
        BlinkAnim.SetBool("Blink", true); //閉眼
    }
    public void officerDisappear(){
        officerState.SetActive(false); //監牢消失
    }*/

}
