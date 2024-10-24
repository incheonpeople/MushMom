using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;       // ScoreButton을 참조
    public TextMeshProUGUI scoreText;     // TextMeshProUGUI 텍스트 필드

    void Awake()
    {
        // ScoreButton의 OnScoreChanged 이벤트에 RefreshUI 메서드를 등록
        scoreButton.OnScoreChanged += RefreshUI;
    }

    // 점수가 변경될 때 호출되는 메서드로, UI 텍스트를 업데이트
    void RefreshUI(int newScore)
    {
        scoreText.text = "Score: " + newScore;
    }
}
