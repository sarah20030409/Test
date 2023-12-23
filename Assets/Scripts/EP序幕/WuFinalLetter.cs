using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WuFinalLetter : MonoBehaviour
{
    //這是用來做吳瑞爐信封飄飄的
    public float LetterUp = 0f;
    public Animator LetterUpAnim ;

    //遺書飄起來的時候切換場警場景
    public Animator BlinkAnim;
    public GameObject WuAndLetter;
    public GameObject BigLetter;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LetterUpAndBlink());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator LetterUpAndBlink() {

        yield return new
        WaitForSeconds(LetterUp);
        LetterUpAnim.SetBool("LetterUp", true);

        yield return new
       WaitForSeconds(6.0f);
        BlinkAnim.SetBool("Blink",true);


        yield return new
       WaitForSeconds(2.0f);
        WuAndLetter.SetActive(false);
        BigLetter.SetActive(true);

    }
    
}
