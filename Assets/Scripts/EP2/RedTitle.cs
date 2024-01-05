using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTitle : MonoBehaviour
{
    public GameObject RedCanva;

    public float ScreenTurnRed = 0f;
    void Start()
    {
        StartCoroutine(ScreenRed());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator ScreenRed() {
    yield return new
    WaitForSeconds(ScreenTurnRed);
    RedCanva.SetActive(true);
    }
    
}
