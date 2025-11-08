using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemGun : Item
{
    [SerializeField] private Transform _barrelGun;
    [SerializeField] private BulletMover _bulletPrefab;

    protected override void ItemAction(GameObject gameObjectUse)
    {
        Shooter shooter = gameObjectUse.GetComponentInParent<Shooter>();

        if (shooter != null)
            Shot();

        Debug.Log("Use Gun");
    }

    private void Shot()
    {
        BulletMover bullet = Instantiate(_bulletPrefab, _barrelGun.position, Quaternion.identity);

        if (bullet == null)
            return;

        bullet.Initialization(transform.forward);
    }
}
