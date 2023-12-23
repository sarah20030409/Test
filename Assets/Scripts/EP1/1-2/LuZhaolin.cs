using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuZhaolin : MonoBehaviour
{
    public Animator BlinkAnim;
    public GameObject LuZhaolinSence;
    public GameObject fishVendorSence;
    public float TalkTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoFishVendor());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator GoFishVendor(){
        yield return new
        WaitForSeconds(TalkTime);
        BlinkAnim.SetBool("Blink", true);

        yield return new
        WaitForSeconds(2.0f);
        LuZhaolinSence.SetActive(false);
        fishVendorSence.SetActive(true);

    }
}
