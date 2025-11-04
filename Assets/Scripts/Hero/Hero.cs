using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Character
{

    private void Awake()
    {
        SetHeroSpeed(Speed);
    }

    public void IncreaseSpeed(int value)
    {
        if (value < 0)
            return;

        Speed *= value;
        SetHeroSpeed(Speed);
    }

    public void IncreaseHealth(int value)
    {
        if (value < 0)
            return;

        Health += value;
        Debug.Log($"Health = {Health}");
    }

    private void SetHeroSpeed(float speed)
    {
        CharacterMover characterMover = gameObject.GetComponent<CharacterMover>();

        if (characterMover == null)
            return;

        characterMover.SetSpeed(speed);
    }
}
