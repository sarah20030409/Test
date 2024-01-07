using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class TouchFingerPrint : MonoBehaviour
{
    public VisualEffect vfx;
    public float DisappearTime;
    private float AlphaValue;
    private bool StartDisappear = false;
    public Material targetMaterial;
    public MonoBehaviour[] script;

    private void Start()
    {
        vfx.Stop();
        targetMaterial.SetFloat("_Alpha", 1);
    }
    public void IfTouchFingerPrint()
    {

        
        StartCoroutine(FingerPrintDisappear());
        

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            IfTouchFingerPrint();
        }

        if (StartDisappear)
        {
            if (AlphaValue >= 0)
            {
                AlphaValue -= Time.deltaTime * 0.01f;
                targetMaterial.SetFloat("_Alpha", AlphaValue);
            }
        }
        else 
        {
            targetMaterial.SetFloat("_Alpha", 1);
        }
    }

    private IEnumerator FingerPrintDisappear()
    {
        foreach (MonoBehaviour item in script)
        {
            item.enabled = false;
        }

        vfx.Play();
        Fingerprint.getFingerPrint = true;
        PorolgueSoundManager.instance.PlayFingerPrintSound();
        PorolgueSoundManager.instance.PlayAfterFingerPrintLines();
        StartDisappear = true;

        yield return new WaitForSeconds(DisappearTime);
        vfx.Stop();
        StartDisappear = false;
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
}
