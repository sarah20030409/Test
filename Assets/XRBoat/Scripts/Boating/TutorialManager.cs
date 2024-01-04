using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    private void Start()
    {
        ShowTutorial();
    }
    public void ShowTutorial()
    {
        gameObject.SetActive(true);
    }
    public void HideTutorial()
    {
        gameObject.SetActive(false);
    }
}
