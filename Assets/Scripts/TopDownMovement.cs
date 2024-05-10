using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // 실제로 이동일 일어날 컴포넌트
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake() // 주로 내 컴포넌트 안에서 끝나는 거
    {
        // controller와 TopDownMovement가 같은 게임오브젝트 안에 있다라는 가정
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // 물리업데이트와 관계가 있음
        // rigidbody의 값을 바꾸니까 FixedUpdate에 적용

        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        movementRigidbody.velocity = direction;
    }
}