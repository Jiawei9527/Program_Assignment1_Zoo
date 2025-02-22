using UnityEngine;

public class Monkey : Animal, IInteractable, IPromptable
{
    //monkey attributes
    public float jumpSpeed = 2f; // Speed of monkey jump
    public float jumpHeight = 3f; // height of moneky jump
    bool jumping = false;
    Vector3 startPosition;
    public void Interact()
    {
        MakeSound();
        jumping = true;
        ShowName();
    }
    public void StopInteract()
    {
        HideName();
        jumping = false;
    }
    public void ShowPrompt()
    {
        if (prompt != null)
        {
            prompt.SetActive(true);
        }
        else
        {
            Debug.Log("Press E to make monkey jump");
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
        startPosition = animalsprite.transform.position;

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q) || jumping)
        {
            Jump();
        }
        else
        {
            animalsprite.transform.position = startPosition;
        }

    }
    void Jump()
    {
        float direction = (Mathf.Sin(Time.time * jumpSpeed) + 1f) * jumpHeight;
        animalsprite.transform.position = new Vector3(startPosition.x, startPosition.y + direction, 0);
    }
    public override void MakeSound()
    {
        Debug.Log("Monkey says: Hoo Gaaa Hoo Gaa!");
    }
}
