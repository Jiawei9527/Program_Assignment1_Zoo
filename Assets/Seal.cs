using UnityEngine;

public class Seal : Animal, IInteractable, IPromptable
{
    //seal attributes
    public float swimSpeed = 2f; // Speed of movement
    public float swimDistance = 3f; // Distance of movement
    bool swimming = false;
    Vector3 startPosition;
    public void Interact()
    {
        MakeSound();
        swimming = true;
        ShowName();
    }
    public void StopInteract()
    {
        HideName();
        swimming = false;
    }
    public void ShowPrompt()
    {
        if (prompt != null)
        {
            prompt.SetActive(true);
        }
        else
        {
            Debug.Log("Press E to make the seal swim");
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
        //key Q is noly test purpose
        if (Input.GetKey(KeyCode.Q) || swimming)
        {
            Swim();
        }
        else
        {
            animalsprite.transform.position = startPosition;
        }

    }
    void Swim()
    {
        float direction = Mathf.Sin(Time.time * swimSpeed) * swimDistance;
        animalsprite.transform.position = new Vector3(startPosition.x + direction, startPosition.y, 0);
    }
    public override void MakeSound()
    {
        Debug.Log("Seal says: Aoo Aoo Aoo!");
    }
}
