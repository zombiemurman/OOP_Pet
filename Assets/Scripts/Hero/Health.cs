using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health = 100;

    public void IncreaseHealth(int value)
    {
        if (value < 0)
            return;

        _health += value;
        Debug.Log($"Health = {_health}");
    }
}
