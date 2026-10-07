using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement = Vector2.zero;

        Keyboard keyboard = Keyboard.current;

        if (keyboard == null)
            return;

        if (keyboard.wKey.isPressed)
            movement.y += 1;

        if (keyboard.sKey.isPressed)
            movement.y -= 1;

        if (keyboard.aKey.isPressed)
            movement.x -= 1;

        if (keyboard.dKey.isPressed)
            movement.x += 1;

        // Evita que Tonalli corra más rápido en diagonal.
        movement = movement.normalized;
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}