using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade01 : MonoBehaviour
{
    public SpriteRenderer TitleSprite; //抓抓SpriteRenderer
    private Color initialColor;//抓抓初始顏色
    public Color EndColor = new Color(0f,0f,0f,0f);
    public float colorChangeSpeed = 0.2f; //過渡時間
    public GameObject fadeTitle;
    public GameObject Officer;

    public float doBlink = 6f;
    public Animator BlinkAnim;
    

    // Start is called before the first frame update
    void Start()
    {
        initialColor = TitleSprite.color;

    }

    // Update is called once per frame
    void Update()
    {
        Invoke("TitleFade", 1.5f);
        Invoke("BlinkEye", doBlink);
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
    
}
