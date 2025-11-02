using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHeal : Item
{

    protected override void ItemAction()
    {
        Hero hero = GetComponentInParent<Hero>();

        if (hero != null)
            hero.IncreaseHealth(10);

        Debug.Log("Use Heal");
    }

}
