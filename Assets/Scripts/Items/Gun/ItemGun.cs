using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemGun : Item
{
    [SerializeField] private Transform _barrelGun;
    [SerializeField] private Bullet _bulletPrefab;

    protected override void ItemAction()
    {
        Shot();
        Debug.Log("Use Gun");
    }

    private void Shot()
    {
        Bullet bullet = Instantiate(_bulletPrefab, _barrelGun.position, Quaternion.identity);

        if (bullet == null)
            return;

        bullet.Initialization(transform.forward);
    }
}
