using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    Vector2 input;
    Vector3 movement;
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        movement = new Vector3(input.x, input.y, 0);
        transform.position = transform.position + movement * moveSpeed * Time.deltaTime;

    }
}

