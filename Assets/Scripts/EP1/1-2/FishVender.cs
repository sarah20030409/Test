using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishVender : MonoBehaviour
{
    public GameObject fishVendorSence;
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

    }
}
