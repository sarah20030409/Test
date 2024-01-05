using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaiBeKilled : MonoBehaviour
{
    public GameObject CaiKilledScene;
    public GameObject KilledTitle;
    public GameObject LectureHallScene;

    public Animator BlackAnim;

    public float TitleDurationTime = 0f;
    void Start()
    {
        StartCoroutine(TitleScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator TitleScene() {
        yield return new
        WaitForSeconds(TitleDurationTime);
        BlackAnim.SetBool("TitleOn",true);

        yield return new
        WaitForSeconds(1.5f);
        KilledTitle.SetActive(false);
        LectureHallScene.SetActive(true);

        yield return new
        WaitForSeconds(1.0f);
        CaiKilledScene.SetActive(false);
    }
}
