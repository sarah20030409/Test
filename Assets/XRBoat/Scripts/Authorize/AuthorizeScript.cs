using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuthorizeScript : MonoBehaviour
{
    public GameObject AuthorizeTtile;
    public Vector3 moveDirection = Vector3.up;
    private float moveSpeed = 5.0f;
    public bool isTriggered = false; //Ä²µoª¬ºA

    // Update is called once per frame
  
    void Update()
    {
        // Debug.Log(isTriggered);

        if (isTriggered) { 
            float distance = Time.deltaTime * moveSpeed;
            AuthorizeTtile.transform.Translate(moveDirection * distance);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
            isTriggered = true;
        }
    }
}
