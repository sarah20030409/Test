using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAeraController : MonoBehaviour
{
    public GameObject TouchAera;
    private void Start()
    {
        HideTouchArea();
    }
    public void ShowTouchArea()
    {
        TouchAera.SetActive(true);

    }
    public void HideTouchArea()
    {
        TouchAera.SetActive(false);
    }
}
