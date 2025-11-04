using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _lifeTime;

    private float _currentLifeTime;

    private void Awake()
    {
        _currentLifeTime = _lifeTime;
    }

    private void Update()
    {
        _currentLifeTime -= Time.deltaTime;

        if ( _currentLifeTime <= 0 )
            Destroy(gameObject);
    }
}
