using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeSceneFunction : MonoBehaviour
{
    
    public static void ChangeScenes(string SceneName)
    {
        SceneManager.LoadSceneAsync(SceneName);
    }
   
}
