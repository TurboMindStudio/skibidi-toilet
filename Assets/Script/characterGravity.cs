using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterGravity : MonoBehaviour
{
    Vector3 moveDirection;
    [SerializeField] CharacterController characterController;

    private void Start()
    {
        moveDirection = Vector3.zero;
    }

    private void Update()
    {
        if (characterController.isGrounded==false)
        {
            moveDirection += Physics.gravity;
        }

        characterController.Move(moveDirection*Time.deltaTime);                     
    }
}
