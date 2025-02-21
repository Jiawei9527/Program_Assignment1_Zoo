using TMPro;
using UnityEngine;

public abstract class Animal: MonoBehaviour
{
    //common attributes
    public string Name;
    public TextMeshProUGUI nameText;
    //common "behaviour" show their name on ui
    public void ShowName()
    {
        if (nameText != null)
        {
            nameText.text = Name;

        }
        else
        {
            Debug.LogError(name);
        }
    }
    //common abstract behaviour to make sound
    public abstract void MakeSound();
}