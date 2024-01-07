using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shinning : MonoBehaviour
{
    public Material targetMaterial;
    public float MaxItensity;
    public float MinItensity;
    public float ShinningSpeed;

    
    private void Update()
    {
        float _IntesityValue = Mathf.Lerp(MaxItensity, MinItensity, Mathf.Sin(Time.time * ShinningSpeed));
        targetMaterial.SetFloat("_Intensity", _IntesityValue);
    }

}
