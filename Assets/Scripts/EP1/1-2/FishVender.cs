using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishVender : MonoBehaviour
{
    public GameObject fishVendorSence;
    public GameObject HongDongSence;

    public Animator littlePaperAnim;
    public Animator PaperOpenAnim;
    public Animator FishVenderBackAnim;

    public float PaperGoUpTime = 0f;
    public float PaperOpenTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoPaperAnim());
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public IEnumerator DoPaperAnim() {
        yield return new
        WaitForSeconds(PaperGoUpTime);
        littlePaperAnim.SetBool("PaperGoUp", true);

        yield return new
        WaitForSeconds(PaperOpenTime);
        PaperOpenAnim.SetBool("PaperOpen", true);

        yield return new
        WaitForSeconds(PaperOpenTime);
        FishVenderBackAnim.SetBool("FishVGoBack", true);

        yield return new
        WaitForSeconds(2.0f);
        HongDongSence.SetActive(true);

        yield return new
       WaitForSeconds(3.0f);
        PaperOpenAnim.SetBool("PaperClose", true);

        yield return new
       WaitForSeconds(4.0f);
        littlePaperAnim.SetBool("PaperDown", true);
    }
}
