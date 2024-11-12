using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using Assignment18;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterTest : MonoBehaviour
{
    Soldier solider;
    Officer officer;
    Character[] array;
    void Start()
    {
        array = new Character[2];
        solider = new Soldier();
        officer = new Officer("fuad", 90, new Position(150, 20, 30));
        array[0] = solider;
        array[1] = officer;
        foreach (Character character in array)
        {
            character.DisplayInfo();
        }
        Debug.Log($"The soldier's health before the officer attacks him is {solider.Health}");
        officer.Attack(60, solider);
        Debug.Log($"The soldier's health after the officer attacks him is{solider.Health}");
    }



}
