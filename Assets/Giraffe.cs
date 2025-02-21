using UnityEngine;

public class Giraffe : Animal
{
    public float ndeckAngle = 30f;
    public float bowSpeed = 1f;
    Quaternion originalRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //run animal behaviour
        ShowName();
        originalRotation = transform.rotation;
    }
    void Update()
    {
        // run all giraffe behaviours when the Q key is pressed, for test purposes only
        if (Input.GetKey(KeyCode.Q))
        {
            Bowhead();
        }
        else
        {
            // Reset rotation when the key is not pressed
            transform.rotation = originalRotation;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            MakeSound();
        }
    }
    private void Bowhead()
    {
        float angle = ndeckAngle * (Mathf.Sin(Time.time * bowSpeed)-1f);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    public override void MakeSound()
    {
        Debug.Log("Giraffe says: pooooof!");
    }
}
