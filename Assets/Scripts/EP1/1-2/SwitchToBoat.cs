using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToBoat : MonoBehaviour
{
    public float SwitchTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SwitchToXRBoat",SwitchTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SwitchToXRBoat()
    {
        ChangeSceneFunction.ChangeScenes("BoatingScene");
    }
}
