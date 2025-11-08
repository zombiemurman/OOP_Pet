using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public virtual void Use(GameObject gameObjectUse)
    {
            ItemAction(gameObjectUse);

            DestroyEffect();

            Destroy(gameObject);
    }

    private void DestroyEffect()
    {
        EffectItem effectItem = gameObject.GetComponent<EffectItem>();

        if (effectItem == null)
            return;

        effectItem.DestroyEffect();
    }

    protected abstract void ItemAction(GameObject gameObjectUse);
}

