using UnityEngine;

public class Seal : Animal
{
    //seal attributes
    public float swimSpeed = 2f; // Speed of movement
    public float swimDistance = 3f; // Distance of movement

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
            Swim();
        }
        else
        {
            transform.position = startPosition;
        }

    }
    void Swim()
    {
        float direction = Mathf.Sin(Time.time * swimSpeed) * swimDistance;
        transform.position = new Vector3(startPosition.x + direction, startPosition.y, 0);
    }
    public override void MakeSound()
    {
        Debug.Log("Seal says: Aoo Aoo Aoo!");
    }
}
