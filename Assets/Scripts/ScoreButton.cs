using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;        // ��ư ����
    public int score = 0;             // ������ �����ϴ� ����
    public Action<int> OnScoreChanged; // ���� ������ �˸��� �̺�Ʈ
    public AnimationController animationController; // �ִϸ��̼� ���� ����

    void Awake()
    {
        // Button ������Ʈ�� �������� Ŭ�� �̺�Ʈ�� PointUp �޼��� ����
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    // ��ư Ŭ�� �� ������ 1 �ø���, �̺�Ʈ�� �߻���Ŵ
    void PointUp()
    {
        score += 1;                     // ������ 1 �ø�
        OnScoreChanged?.Invoke(score);  // �̺�Ʈ �߻� �� ������ �޼��� ȣ��
    }
}
