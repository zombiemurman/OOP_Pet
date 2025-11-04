using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected float Speed = 5;
    [SerializeField] protected int Health = 100;
}
