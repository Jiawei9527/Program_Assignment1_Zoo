using UnityEngine;

public class Giraffe : Animal, IInteractable, IPromptable
{
    public float ndeckAngle = 30f;
    public float bowSpeed = 1f;
    bool bowhead = false;
    Quaternion originalRotation;
    public void Interact()
    {
        MakeSound();
        bowhead = true;
        ShowName();
    }
    public void StopInteract()
    {
        HideName();
        bowhead = false;
    }
    public void ShowPrompt()
    {
        if (prompt != null)
        {
            prompt.SetActive(true);
        }
        else
        {
            Debug.Log("Press E to make the giraffe bow its head");
        }
    }
    public void HidePrompt()
    {
        if (prompt != null)
        {
            prompt.SetActive(false);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        originalRotation = animalsprite.transform.rotation;
    }
    void Update()
    {
        // run all giraffe behaviours when the Q key is pressed, for test purposes only
        if (Input.GetKey(KeyCode.Q)|| bowhead)
        {
            Bowhead();
        }
        else
        {
            // Reset rotation when the key is not pressed
            animalsprite.transform.rotation = originalRotation;
        }
    }
    private void Bowhead()
    {
        float angle = ndeckAngle * (Mathf.Sin(Time.time * bowSpeed)-1f);
        animalsprite.transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    public override void MakeSound()
    {
        Debug.Log("Giraffe says: pooooof!");
    }
}
