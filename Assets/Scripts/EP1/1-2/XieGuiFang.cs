using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XieGuiFang : MonoBehaviour
{
    public Animator BlinkAnim;
    public GameObject XieGuiFangSence;
    public GameObject LuZhaolinSence;
    public float TalkTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartXieSence());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator StartXieSence() {
        yield return new
        WaitForSeconds(1.0f);
        BlinkAnim.SetBool("Blink", true);

        yield return new
       WaitForSeconds(2.0f);
        XieGuiFangSence.SetActive(true);

        yield return new
        WaitForSeconds(TalkTime);
        BlinkAnim.SetBool("Blink", true);

        yield return new
       WaitForSeconds(2.0f);
        XieGuiFangSence.SetActive(false);
        LuZhaolinSence.SetActive(true);
    }
}
