using UnityEngine;

public class Monkey : Animal
{
    //monkey attributes
    public float jumpSpeed = 2f; // Speed of monkey jump
    public float jumpHeight = 3f; // height of moneky jump

    Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        //run animal behaviour
        ShowName();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            MakeSound();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Jump();
        }
        else
        {
            transform.position = startPosition;
        }

    }
    void Jump()
    {
        float direction = (Mathf.Sin(Time.time * jumpSpeed) + 1f) * jumpHeight;
        transform.position = new Vector3(startPosition.x, startPosition.y + direction, 0);
    }
    public override void MakeSound()
    {
        Debug.Log("Monkey says: Hoo Gaaa Hoo Gaa!");
    }
}
