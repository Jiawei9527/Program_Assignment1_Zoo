using System.Xml;
using System;
using UnityEngine;

public class Penguin : Animal
{
    //penguin unique attribute
    public string sound;
    public void ShakeWalk()
    {

    }

    public override void MakeSound()
    {
        Console.WriteLine("Honk!");
    }
}
