using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreButton : MonoBehaviour
{
    public Button scoreButton;        // 버튼 연결
    public int score = 0;             // 점수를 저장하는 변수
    public Action<int> OnScoreChanged; // 점수 변경을 알리는 이벤트
    public AnimationController animationController; // 애니메이션 제어 변수

    void Awake()
    {
        // Button 컴포넌트를 가져오고 클릭 이벤트에 PointUp 메서드 연결
        scoreButton = GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    // 버튼 클릭 시 점수를 1 올리고, 이벤트를 발생시킴
    void PointUp()
    {
        score += 1;                     // 점수를 1 올림
        OnScoreChanged?.Invoke(score);  // 이벤트 발생 및 구독된 메서드 호출
    }
}
