using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Character
{
    private void Update()
    {
        MoveTo();
    }

    public void IncreaseSpeed(int value)
    {
        if (value < 0)
            return;

        Speed *= value;
    }

    public void IncreaseHealth(int value)
    {
        if (value < 0)
            return;

        Health += value;
        Debug.Log($"Health = {Health}");
    }
}
