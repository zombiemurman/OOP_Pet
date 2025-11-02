using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public virtual void Use()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ItemAction();

            Destroy(gameObject);
        }
    }

    protected abstract void ItemAction();
}

