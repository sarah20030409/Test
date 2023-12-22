using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFinalLetter : MonoBehaviour
{
    public Animator LetterMoveI;
    public Animator LetterMoveII;

    public Animator TurnLightOn;
    public Animator BroAppear;
    public Animator DadAppear;
    public Animator LetterState;
    public Animator WhiteSwitch;

    public GameObject LightDotActive;
    public GameObject DoorActive;
    public GameObject BigLetter;
    public GameObject EyeGroup;
    public GameObject WhiteSprite;

    public float BroAppearTime = 0f;
    public float BroTalkTime = 0f;
    public float DadAppearTime = 0f;
    public float DadTalkTime = 0f;
    public float TurnLightOnTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(MoveForward());
    }

    private IEnumerator MoveForward() {

        yield return new
        WaitForSeconds(3.0f);
        LetterMoveII.SetBool("MoveTwo", true);

        yield return new
        WaitForSeconds(1.0f);
        LetterMoveI.SetBool("MoveOne", true);

        yield return new
        WaitForSeconds(TurnLightOnTime);
        TurnLightOn.SetBool("LightOn",true);

        yield return new
        WaitForSeconds(BroAppearTime);
        BroAppear.SetBool("BroForward", true);
        BigLetter.SetActive(false);

        yield return new
        WaitForSeconds(BroTalkTime-4.0f);
        LetterState.SetBool("gaveLetter", true);

        yield return new
        WaitForSeconds(BroTalkTime);
        BroAppear.SetBool("BroBack", true);
        LetterState.SetBool("gaveLetter", true);

        yield return new
        WaitForSeconds(DadAppearTime);
        DadAppear.SetBool("DadForward",true);

        yield return new
        WaitForSeconds(DadTalkTime);
        DadAppear.SetBool("DadBack", true);

        yield return new
        WaitForSeconds(2.0f);
        LightDotActive.SetActive(true);
        EyeGroup.SetActive(false);

        yield return new
        WaitForSeconds(20.0f);
        DoorActive.SetActive(true);

        yield return new
        WaitForSeconds(3.0f);
        LetterMoveII.SetBool("DoorMove",true);

        yield return new
        WaitForSeconds(20.0f);
        WhiteSprite.SetActive(true);
        WhiteSwitch.SetBool("trunWhite",true);


    }
    

}
