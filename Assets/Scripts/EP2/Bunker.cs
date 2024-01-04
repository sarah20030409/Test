using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunker : MonoBehaviour
{
    public GameObject BunkerScene;
    public GameObject CaiKilledScene;
    public GameObject DrinkWater;

    public Animator TalkTalkAnim;
    public Animator BunkerGoBackAnim;

    public float TalkAfterSecond = 0f;
    public float TalkDurationTime = 0f;

    void Start()
    {
        StartCoroutine(Bunker_Scene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Bunker_Scene() {
        yield return new
        WaitForSeconds(TalkAfterSecond);
        TalkTalkAnim.SetBool("TalkTalk",true);
        DrinkWater.SetActive(true);

        yield return new
        WaitForSeconds(TalkDurationTime);
        BunkerGoBackAnim.SetBool("GoBack",true);

        yield return new
        WaitForSeconds(5.0f);
        BunkerScene.SetActive(false);
        CaiKilledScene.SetActive(true);
    }
}
