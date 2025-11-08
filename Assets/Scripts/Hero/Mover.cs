using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    protected string _horizontalAxisName = "Horizontal";
    protected string _verticalAxisName = "Vertical";

    [SerializeField] protected float Speed = 5;

    protected virtual void Update()
    {
        MoveTo();
    }

    protected abstract void MoveTo();

    protected void ProcessMoveTo(Vector3 direction, Transform transform)
    {
        transform.Translate(direction, Space.World);
    }

    public void SetSpeed(float value)
    {
        if(value < 0)
            return;

        Speed = value;
    }
}
