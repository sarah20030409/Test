using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatingVisual : MonoBehaviour
{
    public static BoatingVisual instance { get; private set; }
    [Header("Boat")]
    [SerializeField] private Animator BoatRightPaddleAnim;
    [SerializeField] private Animator BoatLeftPaddleAnim;
    
    

    private void Awake()
    {
        instance = this;

    }
    private void FixedUpdate()
    {
        //Set boat's rotation
        if (XRBoatingAction.WorldVelocity != Vector3.zero)
        {       
            Quaternion targetRotation = Quaternion.LookRotation(XRBoatingAction.WorldVelocity);
            Quaternion targetRotationY = Quaternion.Euler(0, targetRotation.eulerAngles.y, 0); //Only need to change Y direction

            if (Quaternion.Angle(Quaternion.identity, targetRotationY) < 90f) //If the rotate angle < 90
            {
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotationY, Time.deltaTime * 10);
            }


            
        }
    }
    //Set boat's animation
    public void PaddleAnimateTrigger()
    {
        BoatRightPaddleAnim.SetTrigger("Swing");
        BoatLeftPaddleAnim.SetTrigger("Swing");
    }
}
