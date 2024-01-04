using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenTextManager : MonoBehaviour
{
    public TMP_Text ScreenText;
    private float Timer; 
    public void ScreenTextSet(string Text)
    {       
        ScreenText.text = Text;    
    }
    public void ResetScreenText()
    {
        ScreenText.text = " ";
    }

}
