using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HongDongSong : MonoBehaviour
{
    public Animator BowHeadAnim;
    public Animator PickUpPaperAnim;
    public Animator GivePaperAnim;


    // Start is called before the first frame update
    void Start()
    {
        //if () { }
        StartCoroutine(ReadPaper());    
    

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator ReadPaper() {
        yield return new
        WaitForSeconds(20.0f);
        GivePaperAnim.SetBool("GivePaper", true);

        yield return new
        WaitForSeconds(2.0f);
        BowHeadAnim.SetBool("LookPaper", true);
        PickUpPaperAnim.SetBool("LookPaper", true);

     }
}
