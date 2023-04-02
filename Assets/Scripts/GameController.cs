using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static int idleState;
    public static int locomotionState;
    public static int speedParam;
    public static int TurnOnSpotLeftState;
    public static int TurnOnSpotRightState;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();

        idleState = Animator.StringToHash("Idle");
        locomotionState = Animator.StringToHash("Locomotion");
        TurnOnSpotLeftState = Animator.StringToHash("TurnOnSpotLeft");
        TurnOnSpotRightState = Animator.StringToHash("TurnOnSpotRight");
        speedParam = Animator.StringToHash("Speed");
    }
}
