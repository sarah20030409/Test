using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuthorizeScript : MonoBehaviour
{
    public GameObject AuthorizeTtile;
    public Vector3 moveDirection = Vector3.up;
    public float moveSpeed = 20.0f;
    public bool isTriggered = false; //Ĳ�o���A
    

    private void Start()
    {
        
        
    }

    void Update()
    {
         Debug.Log(isTriggered);
        
        if (isTriggered) { 

            float distance = moveSpeed * Time.deltaTime;
            AuthorizeTtile.transform.Translate(moveSpeed*moveDirection * distance);
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
