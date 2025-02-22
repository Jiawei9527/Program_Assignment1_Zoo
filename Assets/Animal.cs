using TMPro;
using UnityEngine;

public abstract class Animal: MonoBehaviour
{
    //common attributes
    public GameObject animalsprite;
    public GameObject NameBox;
    public GameObject prompt;
    //common "behaviour" show their name on ui
    public void ShowName()
    {
        if (NameBox != null)
        {
            NameBox.SetActive(true);

        }
        else
        {
            Debug.LogError(name);
        }
    }
    public void HideName()
    {
        if (NameBox != null)
        {
            NameBox.SetActive(false);
        }
    }
    //common abstract behaviour to make sound
    public abstract void MakeSound();

}