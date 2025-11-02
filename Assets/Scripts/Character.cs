using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected string _horizontalAxisName = "Horizontal";
    protected string _verticalAxisName = "Vertical";

    [SerializeField] protected float Speed = 5;
    [SerializeField] protected float RotationSpeed = 700;
    [SerializeField] protected int Health = 100;


    protected virtual void MoveTo()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(_horizontalAxisName), 0, Input.GetAxisRaw(_verticalAxisName));

        Vector3 normalizeInput = input.normalized;

        Vector3 normalizedMoveTo = normalizeInput * Speed * Time.deltaTime;
        ProcessMoveTo(normalizedMoveTo, transform);

        float step = RotationSpeed * Time.deltaTime;
        ProcessRotateTo(normalizeInput, transform, step);
    }

    private void ProcessMoveTo(Vector3 direction, Transform transform)
    {
        transform.Translate(direction, Space.World);
    }

    private void ProcessRotateTo(Vector3 direction, Transform transform, float step)
    {
        Quaternion lookRotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
    }

}
