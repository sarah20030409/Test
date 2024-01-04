using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideTitle : MonoBehaviour
{
    public GameObject SQLScene;
    public GameObject SuicideScene;
    public GameObject CaiTitleScene;

    public Animator TurnRedAnim;
    public Animator BlackAnim;

    public float TurnRedTime = 0f;

    void Start()
    {
        StartCoroutine(SuicideSence());    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SuicideSence() {
        yield return new
        WaitForSeconds(1.0f);
        SQLScene.SetActive(false);

        yield return new
        WaitForSeconds(TurnRedTime);
        TurnRedAnim.SetBool("TurnRed",true);

        yield return new
        WaitForSeconds(5.0f);
        BlackAnim.SetBool("TitleOn",true);

        yield return new
        WaitForSeconds(1.5f);
        CaiTitleScene.SetActive(true);
        SuicideScene.SetActive(false);

    }
}
