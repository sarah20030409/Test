using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openingVerse : MonoBehaviour
{
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    public GameObject WhiteSprite;

    public Animator Black;
    public Animator WhiteSwitch;
    private float SwitchSpeed = 6.0f;
    private float DelayTime = 1.5f;
    public float DurationTime = 0f;


    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(SswitchTitle());
    }

    // Update is called once per frame
    void Update()
    {
        if (Black.GetBool("TitleOn") == true)
        {
            Invoke("BlackAnimClose", 2.0f);
        }

    }

    private IEnumerator SswitchTitle() {
        yield return new
        WaitForSeconds(3.0f);
        Black.SetBool("TitleOn",true);

        yield return new
        WaitForSeconds(DelayTime);
        T1.SetActive(true);

        yield return new
        WaitForSeconds(SwitchSpeed);
        Black.SetBool("TitleOn", true);

        yield return new
        WaitForSeconds(DelayTime);
        T1.SetActive(false);
        T2.SetActive(true);

        yield return new
        WaitForSeconds(SwitchSpeed);
        Black.SetBool("TitleOn", true);

        yield return new
        WaitForSeconds(DelayTime);
        T2.SetActive(false);
        T3.SetActive(true);

        yield return new
        WaitForSeconds(SwitchSpeed);
        Black.SetBool("TitleOn", true);

        yield return new
        WaitForSeconds(DelayTime);
        T3.SetActive(false);
        T4.SetActive(true);

        yield return new
        WaitForSeconds(SwitchSpeed);
        Black.SetBool("TitleOn", true);

        yield return new
        WaitForSeconds(DelayTime);
        T4.SetActive(false);

        yield return new
        WaitForSeconds(DurationTime);
        WhiteSprite.SetActive(true);
        WhiteSwitch.SetBool("trunWhite",true);

        yield return new
        WaitForSeconds(DelayTime);
        ChangeSceneFunction.ChangeScenes("BoatingScene");

    }

    void BlackAnimClose() {
            Black.SetBool("TitleOn", false);
    }

}
