using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WuFinalLetter: MonoBehaviour
{
    public float LetterUp = 0f;
    public Animator LetterUpAnim ;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DoLetterAnim",LetterUp);
    }

    void DoLetterAnim() {
        LetterUpAnim.SetBool("LetterUp",true);
    }
}
