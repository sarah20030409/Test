using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrWuFinalLetter : MonoBehaviour
{
    public GameObject SecondTitle;
    public GameObject WuAndFinalLetter;
    public Animator BlinkAnim;

    public float TitleFade = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SecondTitleFade", TitleFade);
        Invoke("DoBlink", TitleFade - 1f);
    }

    // Update is called once per frame
    void Update()
    {
       
      
    }

    void SecondTitleFade() {
        SecondTitle.SetActive(false);
        WuAndFinalLetter.SetActive(true);
    }

    void DoBlink() {
        BlinkAnim.SetBool("Blink",true);
    }
    
    
}
