using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectureHall : MonoBehaviour
{
    public GameObject LectureHallScene;
    public GameObject ShotScene;

    public Animator SpotLightMove;
    public Animator PolicerTalkAnim;

    public float PolicerTalkAfterSecond = 0f;
    public float PolicerTalkTime = 0f;

    void Start()
    {
        StartCoroutine(LectureHallScript());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator LectureHallScript() {
        yield return new
        WaitForSeconds(PolicerTalkAfterSecond);
        SpotLightMove.SetBool("LightMove",true);
        PolicerTalkAnim.SetBool("PolicerTalk",true);

        yield return new
        WaitForSeconds(PolicerTalkTime);
        LectureHallScene.SetActive(false);
        ShotScene.SetActive(true);

    }
}
