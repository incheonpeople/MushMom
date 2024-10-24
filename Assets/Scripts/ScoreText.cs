using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;       // ScoreButton�� ����
    public TextMeshProUGUI scoreText;     // TextMeshProUGUI �ؽ�Ʈ �ʵ�

    void Awake()
    {
        // ScoreButton�� OnScoreChanged �̺�Ʈ�� RefreshUI �޼��带 ���
        scoreButton.OnScoreChanged += RefreshUI;
    }

    // ������ ����� �� ȣ��Ǵ� �޼����, UI �ؽ�Ʈ�� ������Ʈ
    void RefreshUI(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
}
