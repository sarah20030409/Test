using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string targetSenceName;
    public Animator WhiteSwitch;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (WhiteSwitch.GetBool("trunWhite") == true)
        {
            Invoke("SwitchToNextSence",5.0f);
        }
    }

    void SwitchToNextSence()
    {
        SceneManager.LoadScene(targetSenceName);
    }
}
