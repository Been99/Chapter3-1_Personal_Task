using UnityEngine;
using UnityEngine.UI;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private Transform playerPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirecion)
    {
        RotateArm(newAimDirecion);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;

        playerPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
