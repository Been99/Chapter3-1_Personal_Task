using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera camera;
    private void Awake()
    {
        camera = Camera.main; // mainCamera 태그가 붙어있는 카메라를 가져옴
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized; // 크기가 1인 벡터로 설정
        CallMoveEvent(moveInput);
        // 실제 움직이는 처리는 여기서 하는게 아니라 PlayerMovement에서 함
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>(); // 마우스 위치라서 normalized 하면 안됨
        Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        // 카메라를 기준으로, 마우스좌표계가 존재하는 스크린좌표계에서 월드좌표계로 바꾸라는 의미
        newAim = (worldPos - (Vector2)transform.position).normalized;
        // transform.position에서 worldPos이 어느 위치에 있는지를 표현한 것
        // (마우스와 캐릭터와의 거리가 얼마나 되는지 계산하는 것)

        if(newAim.magnitude >= 0.9f)
        {
            CallLookevent(newAim);
        }
    }
}
