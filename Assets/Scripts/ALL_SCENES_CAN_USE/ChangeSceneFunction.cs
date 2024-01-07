using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeSceneFunction : MonoBehaviour
{
    public static int CurrentStarIndex = 0;
    public static void ChangeScenes(string SceneName)
    {
        SceneManager.LoadSceneAsync(SceneName);
        if(SceneName== "BoatingScene")
        {
            CurrentStarIndex += 1;  
        }
        if (SceneName == "Head")
        {
            CurrentStarIndex = 0;
        }
    }
   
}
