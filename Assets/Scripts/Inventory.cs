using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Item Item { get; private set; }

    public void Add(Item item)
    {
        Item = item;
    }
}
