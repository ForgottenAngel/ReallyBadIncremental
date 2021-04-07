using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ItemEnumTables;
using BreakInfinity;

using Items;
using ItemReferenceTable;

using Inventory;

public class invtest : MonoBehaviour
{

    public List<Items.equipmentItem> jimmieItems = new List<Items.equipmentItem>();
    public equipmentItem itemRef = new equipmentItem();
    public itemCollection itemList = new itemCollection();


    // Start is called before the first frame update
    void Start()
    { 
        giveJimmieItem(0);
        giveJimmieItem(1);
    }

    //Testing the addition of an item to player
    public void giveJimmieItem(int id)
    {
        equipmentItem impending = new equipmentItem();
        equipItemInfo impendingRef = itemList.equipmentList[id];

        impending._equipSlot = impendingRef.equipSlot;
        impending._levelReq = impendingRef.levelReq;
        impending._baseEquipStats.setStats(impendingRef.baseEquipStats.strG, impendingRef.baseEquipStats.intG, impendingRef.baseEquipStats.conG, impendingRef.baseEquipStats.wilG);
        jimmieItems.Add(impending);
        Debug.Log("Gave Jimmie : " + impendingRef.itemInfo.itemName);
    }
}




