using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawning : MonoBehaviour
{
    public Transform[] SpawningPos;
    public GameObject[] FadeIns;
    public int CurrentPosIndex;
    public bool TestMode;

    private void Start()
    {
        if (!TestMode)
            SetCurrentPosIndex();

        
        SetPlayerPos();
        SetFadeIn();
    }
    public void SetCurrentPosIndex()
    {
        CurrentPosIndex = ChangeSceneFunction.CurrentStarIndex;
    }

    public void SetPlayerPos()
    {
        transform.position = SpawningPos[CurrentPosIndex - 1].position;
    }

    public void SetFadeIn()
    {
        for (int i = 0; i < FadeIns.Length; i++)
        {
            if (i == CurrentPosIndex - 1)
            {
                FadeIns[CurrentPosIndex - 1].SetActive(true);
            }
            else
            {
                FadeIns[i].SetActive(false);
            }

        }
    }

}
