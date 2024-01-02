using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchFingerPrint : MonoBehaviour
{

    
    public void IfTouchFingerPrint()
    {
        gameObject.SetActive(false);
        Fingerprint.getFingerPrint = true;
        SoundManager.instance.PlayFingerPrintSound();
        SoundManager.instance.PlayAfterFingerPrintLines();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            IfTouchFingerPrint();
        }
    }
}
