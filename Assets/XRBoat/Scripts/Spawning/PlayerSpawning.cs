using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawning : MonoBehaviour
{
    public int CurrentPosIndex;
    public Transform[] SpawningPos;
    public bool TestMode;

    private void Start()
    {
        if (!TestMode)
            SetCurrentPosIndex();

        
        SetPlayerPos();
    }
    public void SetCurrentPosIndex()
    {
        CurrentPosIndex = ChangeSceneFunction.CurrentStarIndex;
    }

    public void SetPlayerPos()
    {
        transform.position = SpawningPos[CurrentPosIndex - 1].position;
    }

}
