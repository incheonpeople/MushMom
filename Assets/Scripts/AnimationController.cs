using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    // _animator 세팅 
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        // animationVariable 값을 0 → 1 → 2 → 0으로 순환시킴
        animationVariable++;
        if (animationVariable > 2)
        {
            animationVariable = 0;
        }

        // animationVariable을 수정
        _animator.SetInteger("State", animationVariable);
    }
}
