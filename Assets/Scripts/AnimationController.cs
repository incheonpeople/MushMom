using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0; // �ִϸ��̼� ���� ���� (0, 1, 2)
    private Animator _animator; // Animator ������Ʈ�� ������ ����
    // _animator ����
    void Awake()
    {
        _animator = GetComponent<Animator>(); // Animator ������Ʈ�� ������
    }
    void OnMouseDown()
    {
        // animationVariable ���� 0 �� 1 �� 2 �� 0���� ��ȯ��Ŵ
        animationVariable++;
        if (animationVariable > 2)
        {
            animationVariable = 0;
        }
        // animationVariable�� ����
        _animator.SetInteger("State", animationVariable);
    }
}
