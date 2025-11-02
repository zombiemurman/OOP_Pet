using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsCollector : MonoBehaviour
{

    [SerializeField] private Inventory _inventory;

    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponent<Item>();

        if (item == null )
            return;

        if (_inventory.Item != null)
            return;

        item.transform.SetParent(transform);
        item.transform.position = _inventory.transform.position;

        item.transform.rotation = transform.rotation;

        _inventory.Add(item);
            
    }
}
