using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    IInteractable currentInteractable;
    Vector2 input;
    Vector3 movement;
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        movement = new Vector3(input.x, input.y, 0);
        transform.position = transform.position + movement * moveSpeed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.E) && currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        currentInteractable = other.GetComponent<IInteractable>();
        if (currentInteractable != null)
        {
            //Debug.Log("triger name:"+currentInteractable);
            // Show prompt
            if (other.GetComponent<IPromptable>() != null)
            {
                other.GetComponent<IPromptable>().ShowPrompt();
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<IInteractable>() != null)
        {
            currentInteractable.StopInteract();
            currentInteractable = null;
            // Hide prompt
            other.GetComponent<IPromptable>().HidePrompt();
        }
    }
}

