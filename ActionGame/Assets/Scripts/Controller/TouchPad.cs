using UnityEngine;

public class TouchPad : MonoBehaviour
{
    //UI에서 사용하는 트랜스폼
    private RectTransform _touchPad;

    //터치 입력 중에 방향 컨트롤러의 영역 안에 있는 입력을 구분하기 위한 고유 식별 코드(아이디)
    private int _touchId = -1;

    private Vector3 _startPos = Vector3.zero; // 0

    // 방향 컨트롤러가 원으로 움직이는 반지름
    public float _dragRadius = 60.0f;

    //플레이어의 움직임을 관리하는 PlayerMovement와 연결해
    //방향키가 전달되면 캐릭터에게 신호를 보내는 역할
    public PlayerMovement _player;

    //버튼 눌렸는지를 체크하는 변수
    private bool _buttonPressed = false;
}

