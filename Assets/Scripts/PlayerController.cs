using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        animator.SetFloat(GameController.speedParam, verticalInput);

        // Check if the player is stopped (playing the Idle animation)
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            // If the player is stopped, check horizontal input for turning animations
            if (horizontalInput < 0)
            {
                // Play TurnOnSpotLeftA animation if horizontal input is negative
                animator.Play(GameController.TurnOnSpotLeftState);
            }
            else if (horizontalInput > 0)
            {
                // Play TurnOnSpotRightA animation if horizontal input is positive
                animator.Play(GameController.TurnOnSpotRightState);
            }
        }
    }
}


