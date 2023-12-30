using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteSwitch : MonoBehaviour
{
    public Animator WhiteAnim;

    // Start is called before the first frame update
    void Start()
    {

        Invoke("WhiteScreen",2.0f);
       



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void WhiteScreen() {
        WhiteAnim.SetBool("WhiteOff", true);
    }
    
}
