using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private const string IS_WALKING = "isWalking";
    private Animator animator;
    [SerializeField] private Player player;
    private bool isWalking;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        isWalking = player.IsWalking();
        animator.SetBool(IS_WALKING, isWalking);
        
    }
}
