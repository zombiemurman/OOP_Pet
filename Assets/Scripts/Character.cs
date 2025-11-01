using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected string _horizontalAxisName = "Horizontal";
    protected string _verticalAxisName = "Vertical";

    [SerializeField] protected float _speed = 5;
    [SerializeField] protected float _rotationSpeed = 700;

    protected virtual void MoveTo()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(_horizontalAxisName), 0, Input.GetAxisRaw(_verticalAxisName));

        Vector3 normalizeInput = input.normalized;

        Vector3 normalizedMoveTo = normalizeInput * _speed * Time.deltaTime;
        ProcessMoveTo(normalizedMoveTo, transform);

        float step = _rotationSpeed * Time.deltaTime;
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
