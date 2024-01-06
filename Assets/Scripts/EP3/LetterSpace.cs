using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterSpace : MonoBehaviour
{
    public GameObject LetterSpaceOBJ;
    public GameObject ChenQuanShui;

    public Animator BlackCover;

    public float StartLetter = 0f;
    public float EndLetter = 0f;

    void Start()
    {
        StartCoroutine(LetterBall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator LetterBall() {
        yield return new
        WaitForSeconds(0.5f);
        LetterSpaceOBJ.SetActive(false);

        yield return new
        WaitForSeconds(StartLetter);
        BlackCover.SetBool("Black",true);
        
        yield return new
        WaitForSeconds(1.5f);
        LetterSpaceOBJ.SetActive(true);
        BlackCover.SetBool("Black", false);

        yield return new
        WaitForSeconds(EndLetter);
        BlackCover.SetBool("Black", true);

        yield return new
        WaitForSeconds(1.5f);
        LetterSpaceOBJ.SetActive(false);
        ChenQuanShui.SetActive(true);
        BlackCover.SetBool("Black", false);

    }
}
