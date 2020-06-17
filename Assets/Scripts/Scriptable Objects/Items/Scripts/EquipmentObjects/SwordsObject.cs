using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Swords Item", menuName = "Inventory System/Items/Equipment/Swords")]

public class SwordsObject : EquipmentObject
{
    public void Awake()
    {
        equipmentType = EquipmentType.Swords;
    }
}
