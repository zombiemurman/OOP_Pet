using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpeed : Item
{
    //public override void Use()
    //{
    //    base.Use();

        
    //}

    protected override void ItemAction()
    {
        Hero hero = GetComponentInParent<Hero>();

        if (hero != null)
            hero.IncreaseSpeed(10);

        Debug.Log("Use Speed");
    }

}
