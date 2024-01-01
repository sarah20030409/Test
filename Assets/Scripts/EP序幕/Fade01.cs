using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade01 : MonoBehaviour
{
    public SpriteRenderer TitleSprite; 
    private Color initialColor;
    public Color EndColor = new Color(0f,0f,0f,0f);
    public float colorChangeSpeed = 0.2f;
    public GameObject fadeTitle;
    public GameObject Officer;

    public float doBlink = 5f;
    public Animator BlinkAnim;
    

    // Start is called before the first frame update
    void Start()
    {
        initialColor = TitleSprite.color;
        //StartCoroutine(FirstSecneSwitch());

        Invoke("BlinkEye", doBlink);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("TitleFade", 1.5f);
        Invoke("SetFalse1SetTrue2", doBlink + 1f);

    }

    void TitleFade() {
        TitleSprite.color = Color.Lerp(TitleSprite.color, EndColor, colorChangeSpeed * Time.deltaTime);

        if (TitleSprite.color == EndColor) {
            enabled = false;
        }
    }

    void BlinkEye() {
        BlinkAnim.SetBool("Blink",true);
    }

    void SetFalse1SetTrue2() {
        fadeTitle.SetActive(false);
        Officer.SetActive(true);
       
    }

    private IEnumerator FirstSecneSwitch() {
        yield return new
        WaitForSeconds(1.5f);
        TitleFade();

        yield return new
        WaitForSeconds(doBlink);
        BlinkEye();

        yield return new
        WaitForSeconds(doBlink);
        SetFalse1SetTrue2();
    }
    
}
