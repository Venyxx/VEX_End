using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    CharacterController characterController;
    public float MovementSpeed =1;
    

    private Camera cam;
 
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        cam = Camera.main;
    }
 
    void Update()
    {
        // player movement - forward, backward, left, right
        float horizontal = Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);
    }



}
