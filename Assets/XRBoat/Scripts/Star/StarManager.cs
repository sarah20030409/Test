using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    public GameObject[] TeleportPoints;
    public GameObject[] CircleEffects;
    public Material[] StarShaders;
    public int CurrentPosIndex;
    public bool TestMode;

    private void Start()
    {
        if(!TestMode)
            SetCurrentPosIndex();


        SetCurrentStarTeleportPoint();
        SetCurrentStarCircleEffect();
        SetCurrentStarStarShaders();
        
    }
    public void SetCurrentPosIndex()
    {
        CurrentPosIndex = ChangeSceneFunction.CurrentStarIndex;
    }

    public void SetCurrentStarTeleportPoint()
    {
        for (int i = 0; i < TeleportPoints.Length; i++)
        {
            if( i == CurrentPosIndex - 1)
            {
                TeleportPoints[CurrentPosIndex - 1].SetActive(true);
            }
            
        }
        
    }
    public void SetCurrentStarCircleEffect()
    {
        for (int i = 0; i < CircleEffects.Length; i++)
        {
            if (i == CurrentPosIndex - 1)
            {
                CircleEffects[CurrentPosIndex - 1].SetActive(true);
            }
           
        }
    }
    public void SetCurrentStarStarShaders()
    {
        for (int i = 0; i < StarShaders.Length; i++)
        {
            if (i == CurrentPosIndex - 1)
            {
                StarShaders[CurrentPosIndex - 1].SetFloat("_Intesity", 10);
            }
            
        }
    }

}
