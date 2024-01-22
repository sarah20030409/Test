using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Starting : MonoBehaviour
{
    public GameObject AirPlane;
    public GameObject BlackCover;
    [SerializeField] private InputActionReference RightHandControllerGrab; //VRPress
    public ScreenTextManager _ScreenTextManager;

    public float AfterSecondSwitch;
    private void Start()
    {
        _ScreenTextManager.ScreenTextSet("(按住右搖桿前方的按鈕並觸碰光球開始)");
    }
    public void StartGame()
    {
       

            StartCoroutine(Start_Game());
            _ScreenTextManager.ResetScreenText();
        

       
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
        AirPlane.SetActive(true);

        yield return new
        WaitForSeconds(AfterSecondSwitch);
        BlackCover.SetActive(true);

        yield return new
        WaitForSeconds(1.5f);
        ChangeSceneFunction.ChangeScenes("prologueScene");

    }
}
