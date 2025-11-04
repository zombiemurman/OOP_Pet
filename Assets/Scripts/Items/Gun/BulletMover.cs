using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : CharacterMover
{
    private Vector3 _directionShot;

    protected override void Update()
    {
        base.Update();
    }

    protected override void MoveTo()
    {
        if (_directionShot == Vector3.zero)
            return;

        Vector3 normalizeInput = _directionShot.normalized;

        Vector3 normalizedMoveTo = normalizeInput * Speed * Time.deltaTime;

        ProcessMoveTo(normalizedMoveTo, transform);
    }

    public void Initialization(Vector3 directionShot)
    {
        _directionShot = directionShot;
    }

}
