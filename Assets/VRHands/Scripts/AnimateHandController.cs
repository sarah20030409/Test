using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//Make sure Obj have Animator
[RequireComponent(typeof(Animator))]
public class AnimateHandController : MonoBehaviour
{
    //Get InputAction Data
    [SerializeField] private InputActionReference GripInputActionReference;
    [SerializeField] private InputActionReference TriggerInputActionReference;
    //Animation
    private Animator Anim;
    //Value
    private float GripValue;
    private float TriggerValue;
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        GripAnimate();
        TriggerAnimate();
    }

    private void GripAnimate()
    {
        GripValue = GripInputActionReference.action.ReadValue<float>();
        Anim.SetFloat("Grip", GripValue);
    }
    private void TriggerAnimate()
    {
        TriggerValue = TriggerInputActionReference.action.ReadValue<float>();
        Anim.SetFloat("Trigger", TriggerValue);
    }
}
