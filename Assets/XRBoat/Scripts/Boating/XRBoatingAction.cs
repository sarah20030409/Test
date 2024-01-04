using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Rigidbody))]
public class XRBoatingAction : MonoBehaviour
{
    
    [Header("Values")]
    [SerializeField] private float SwimForce = 2f;
    [SerializeField] private float DragForce = 1f;
    [SerializeField] private float MinForce;
    [SerializeField] private float MinTimeBetweenStrokes;
    

    [Header("InputReference")]
    [SerializeField] private InputActionReference LeftHandControllerSwimReference; //VRPress
    [SerializeField] private InputActionReference LeftHandControllerVelocity; //VRControllerVelocity
    [SerializeField] private InputActionReference RightHandControllerSwimReference;
    [SerializeField] private InputActionReference RightHandControllerVelocity; 

    [Header("Player")]
    [SerializeField] private Transform TrackingReference; //Use VROrign's forward direction
    public static Vector3 WorldVelocity; //About direction

    [Header("Tutorial Manager")]
    public TutorialManager _TutorialManager;

    private Rigidbody Rigi;
    private float CoolDownTimer;

    private void Awake()
    {
        
        Rigi = GetComponent<Rigidbody>();
        Rigi.useGravity = false; //Disable gravity when start
        Rigi.constraints = RigidbodyConstraints.FreezeRotation; //Freeze rigibody's rotation
        Rigi.constraints = RigidbodyConstraints.FreezePositionY; //Freeze rigibody's Y position
    }
    private void FixedUpdate()
    {
        CoolDownTimer += Time.deltaTime;
        if (CoolDownTimer>=MinTimeBetweenStrokes
            && LeftHandControllerSwimReference.action.IsPressed()
            && RightHandControllerSwimReference.action.IsPressed())
        {
            var LeftHandVelocity = LeftHandControllerVelocity.action.ReadValue<Vector3>();
            var RightHandVelocity = RightHandControllerVelocity.action.ReadValue<Vector3>();
            
            Vector3 LocalVelocity = LeftHandVelocity + RightHandVelocity;
            
            //LocalVelocity *= -1; //Action Dirrection Select

            if (LocalVelocity.sqrMagnitude > MinForce * MinForce)
            {

                //Aniimation
                BoatingVisual.instance.PaddleAnimateTrigger();


                //WorldVelocity
                WorldVelocity = TrackingReference.TransformDirection(LocalVelocity);

                //PlayerForce
                Rigi.AddForce(WorldVelocity * SwimForce, ForceMode.Acceleration);

                CoolDownTimer = 0f;
            }
           
        }
        if (Rigi.velocity.sqrMagnitude >= 0.01f)
        {
            Rigi.AddForce(-(Rigi.velocity) * DragForce, ForceMode.Acceleration);
            _TutorialManager.HideTutorial();
        }
        else
            _TutorialManager.ShowTutorial();

    }

    
}
