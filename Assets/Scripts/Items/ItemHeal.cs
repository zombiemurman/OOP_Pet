using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHeal : Item
{
    private int _heal = 10;

    protected override void ItemAction(GameObject gameObjectUse)
    {
        Health health = gameObjectUse.GetComponentInParent<Health>();

        if (health != null)
            health.IncreaseHealth(_heal);

        Debug.Log("Use Heal");
    }
}
