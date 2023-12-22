using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetPokeToFingerAttachPoint : MonoBehaviour
{
    public Transform PokeAttachPoint;
    private XRPokeInteractor _xrPokeInteractor;
    
    private void Start()
    {
        _xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
        SetPokeAttach();
    }
    void SetPokeAttach()
    {
        if (PokeAttachPoint == null)
        {
            Debug.Log("Don't have attach point");
            return;
        }
        if (_xrPokeInteractor == null)
        {
            Debug.Log("Don't have PokeInteractor");
            return;
        }
        _xrPokeInteractor.attachTransform = PokeAttachPoint;

    }
}
