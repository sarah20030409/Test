using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkState : MonoBehaviour
{
    public Animator BlinkAnim;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isBlinking = BlinkAnim.GetBool("Blink");

        if (isBlinking == true) {
            Invoke("CloseBlink",3.0f);
        }

    }

    void CloseBlink() {
        BlinkAnim.SetBool("Blink", false);
    }
}
