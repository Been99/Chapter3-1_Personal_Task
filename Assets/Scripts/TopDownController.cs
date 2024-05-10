using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Action은 무조건 void만 반환해야 함 아니면 Func
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction) // Event가 발생 시 Invoke하는 역할을 함
    {
        OnMoveEvent?.Invoke(direction); // ?.  의 의미 : 없으면 말고 있으면 실행함을 뜻함
    }

    public void CallLookevent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
