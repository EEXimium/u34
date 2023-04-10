using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class movement : MonoBehaviour
{
    private Rigidbody characterMedium;
    public Vector2 moveVal;
    public float moveSpeed = 10;
    private void Awake()
    {
        characterMedium = GetComponent<Rigidbody>();

    }
    public void Moving(InputAction.CallbackContext value)
    {

        if (value.performed)
        {
            //Debug.Log("performed");
            moveVal = value.ReadValue<Vector2>();
            //Debug.Log(moveVal.x + "" + moveVal.y);
            //characterMedium.AddForce(new Vector3(moveVal.x * moveSpeed, 0f, moveVal.y * moveSpeed), ForceMode.Impulse);
        }
        if (value.canceled) 
        {
            moveVal = value.ReadValue<Vector2>();
        }
    }
}

