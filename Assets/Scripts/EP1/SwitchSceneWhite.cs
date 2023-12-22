using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSceneWhite : MonoBehaviour
{
    public GameObject WhiteSprite;
    public Animator WhiteSwitch;


    // Start is called before the first frame update
    void Start()
    {
        WhiteSwitch.SetBool("WhiteOff", true);
        Invoke("SwitchSceneWhiteBox", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SwitchSceneWhiteBox() {
        WhiteSprite.SetActive(false);
        WhiteSwitch.SetBool("WhiteOff", false);
    }
}
