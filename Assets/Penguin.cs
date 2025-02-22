using System;
using UnityEngine;

public class Penguin : Animal, IInteractable, IPromptable
{
    //penguin unique attributes
    public float shakeAngle = 30f;
    public float shakeSpeed = 1f;
    bool walking = false;
    Quaternion originalRotation;
    public void Interact()
    {
        MakeSound();
        walking = true;
        ShowName();
    }
    public void StopInteract()
    {
        HideName();
        walking = false;
    }
    public void ShowPrompt()
    {
        if(prompt != null)
        {
            prompt.SetActive(true);
        }
        else
        {
            Debug.Log("Press E to make the penguin walk");
        }
    }
    public void HidePrompt()
    {
        if (prompt != null)
        {
            prompt.SetActive(false);
        }
    }
    void Start()
    {
        originalRotation = animalsprite.transform.rotation;
    }

    void Update()
    {
        // run all penguin behaviours when the Q key is pressed, for test purposes only
        if (Input.GetKey(KeyCode.Q) || walking)
        {
            ShakeWalk();
        }
        else
        {
            // Reset rotation when the key is not pressed
            animalsprite.transform.rotation = originalRotation;

        }
    }
    private void ShakeWalk()
    {
        float angle = shakeAngle * Mathf.Sin(Time.time * shakeSpeed);
        animalsprite.transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public override void MakeSound()
        {
            Debug.Log("Penguin says: Honk!");
        }
}
