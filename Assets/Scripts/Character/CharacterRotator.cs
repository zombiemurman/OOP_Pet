using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterRotator : MonoBehaviour
{
    protected string _horizontalAxisName = "Horizontal";
    protected string _verticalAxisName = "Vertical";

    [SerializeField] protected float RotationSpeed = 700;
    
    protected virtual void Update()
    {
        RotateTo();
    }

    protected abstract void RotateTo();

    protected void ProcessRotateTo(Vector3 direction, Transform transform, float step)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }
}
