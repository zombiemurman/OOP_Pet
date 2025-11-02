using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectItem : MonoBehaviour
{
    [SerializeField] private ParticleSystem _destroyEffectPrefab;

    public void DestroyEffect()
    {
        ParticleSystem destroyEffectPrefab = Instantiate(_destroyEffectPrefab, transform.position, Quaternion.identity);

        if (destroyEffectPrefab == null)
            return;

        destroyEffectPrefab.Play();

    }

}
