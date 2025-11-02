using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemInventory : MonoBehaviour
{
    [SerializeField] private Inventory _inventory;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            Item item = _inventory.Item;

            if(item == null)
            {
                Debug.Log("Инвентарь пуст");
                return;
            }

            item.Use();
        }
    }
}
