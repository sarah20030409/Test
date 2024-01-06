using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{
    public void StartGame()
    {
        
        ChangeSceneFunction.ChangeScenes("prologueScene");
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
            ChangeSceneFunction.ChangeScenes("prologueScene");
    }

}
