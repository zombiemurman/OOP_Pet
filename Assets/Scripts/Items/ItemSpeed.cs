using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpeed : Item
{
    private float _speed = 20;

    protected override void ItemAction(GameObject gameObjectUse)
    {
        Mover mover = gameObjectUse.GetComponentInParent<Mover>();

        if (mover != null)
            mover.SetSpeed(_speed);

        Debug.Log("Use Speed");
    }
}
