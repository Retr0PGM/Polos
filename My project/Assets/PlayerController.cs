using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    move_desgraxa controller;
    float horizontalMove = 0f;
    [SerializeField]
    float runSpeed = 40f;
    bool jump = false;
    void Start()
    {
        controller = GetComponent<move_desgraxa>();        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    void FixedUpdate() 
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime,false,jump);
        jump = false;       
    }
}
