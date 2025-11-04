using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMover : CharacterMover
{

    protected override void Update()
    {
        base.Update();
    }

    protected override void MoveTo()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw(_horizontalAxisName), 0, Input.GetAxisRaw(_verticalAxisName));

        Vector3 normalizeInput = input.normalized;

        Vector3 normalizedMoveTo = normalizeInput * Speed * Time.deltaTime;
        ProcessMoveTo(normalizedMoveTo, transform);
    }
}
