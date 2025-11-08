using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroRotator : Rotator
{
    protected override void Update()
    {
        base.Update();
    }

    protected override void RotateTo()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(_horizontalAxisName), 0, Input.GetAxisRaw(_verticalAxisName));

        Vector3 normalizeInput = input.normalized;

        if (input == Vector3.zero)
            return;

        float step = RotationSpeed * Time.deltaTime;
        ProcessRotateTo(normalizeInput, transform, step);
    }
}
