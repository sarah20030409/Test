using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{

    public float AfterSecondSwitch;

    public void StartGame()
    {
        StartCoroutine(Start_Game());
        
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            StartCoroutine(Start_Game());
        }
    }

    private IEnumerator Start_Game() {
        yield return new
        WaitForSeconds(1.0f);


        yield return new
        WaitForSeconds(AfterSecondSwitch);
        ChangeSceneFunction.ChangeScenes("prologueScene");

    }
}
