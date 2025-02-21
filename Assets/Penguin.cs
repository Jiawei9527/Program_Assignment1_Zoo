using System;
using UnityEngine;

public class Penguin : Animal
{
    //penguin unique attributes
    public float shakeAngle = 30f;
    public float shakeSpeed = 1f;
    Quaternion originalRotation;

    void Start()
    {
        originalRotation = transform.rotation;
        //run animal behaviour
        ShowName();
    }

    void Update()
    {
        // run all penguin behaviours when the Q key is pressed, for test purposes only
        if (Input.GetKey(KeyCode.Q))
        {
            ShakeWalk();
        }
        else
        {
            // Reset rotation when the key is not pressed
            transform.rotation = originalRotation;

        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            MakeSound();
        }
    }
    private void ShakeWalk()
    {
        float angle = shakeAngle * Mathf.Sin(Time.time * shakeSpeed);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public override void MakeSound()
        {
            Debug.Log("Penguin says: Honk!");
        }
}
