using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0; // 애니메이션 상태 변수 (0, 1, 2)
    private Animator _animator; // Animator 컴포넌트를 참조할 변수
    // _animator 세팅
    void Awake()
    {
        _animator = GetComponent<Animator>(); // Animator 컴포넌트를 가져옴
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
