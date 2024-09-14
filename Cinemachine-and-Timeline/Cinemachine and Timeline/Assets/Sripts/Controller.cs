using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");


        if (!isWalking && forwardPressed) //if wala galakat pero nakapress walk, malakat
        {
            animator.SetBool(isWalkingHash, true);
        }
        if (isWalking && !forwardPressed) // if galakat pero wala na gapress walk, mauntat
        {
            animator.SetBool(isWalkingHash, false);
        }
        if (!isRunning &&(forwardPressed && runPressed)) // if wala gadalagan pero gapress w kag left shit, madalagan
        {
            animator.SetBool(isRunningHash, true);
        }
        if (isRunning &&(forwardPressed && !runPressed)) // if gadalagan pero ang w lng ginapress, mabalik lakat
        {
            animator.SetBool(isRunningHash, false);
        }
        if (isRunning &&(!forwardPressed && !runPressed)) // if gadalagan pero wala na gapress w kag left shift, mauntat
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
