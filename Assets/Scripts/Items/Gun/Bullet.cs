using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _lifeTime;

    private Vector3 _directionShot;

    private void Update()
    {
        if (_directionShot == Vector3.zero)
            return;

        ProcessMoveTo(_directionShot, transform);
    }

    public void Initialization(Vector3 directionShot)
    {
        _directionShot = directionShot;
    }

    private void ProcessMoveTo(Vector3 direction, Transform transform)
    {
        transform.Translate(direction, Space.World);
    }

}
