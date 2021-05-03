using System;
using System.Collections;
using System.Collections.Generic;

using ItemEnumTables;
using Items;

namespace Inventory
{

    public class inventoryHandler
    {
        public const int MAX_ITEMS = 24;
        private Dictionary<int, equipmentItem> equipInv;
        private Dictionary<int, healItem> consInv;

        public inventoryHandler()
        {
            equipInv = new Dictionary<int, equipmentItem>();
            consInv = new Dictionary<int, healItem>();
        }

        // Inventory Grabber Functions
        public equipmentItem GetEquipItem(int slot)
        {
            if (equipInv.ContainsKey(slot))
            {
                return equipInv[slot];
            }

            return null;
        }

        public healItem GetConsumableItem(int slot)
        {
            return consInv[slot];
        }


        // Inventory Adder Functions
        public bool AddEquipItem(equipmentItem item, int slot, bool firstOpenSlot)
        {
            if (!firstOpenSlot)
            {
                if (!equipInv.ContainsKey(slot))
                {
                    equipInv.Add(slot, item);
                    return true;
                }
                else
                {
                    return false;
                }
            } else
            {
                for (int i = 0; i < MAX_ITEMS; ++i)
                {
                    if (!equipInv.ContainsKey(i))
                    {
                        equipInv.Add(i, item);
                        return true;
                    }
                }

                return false;
            }
        }

        public bool AddConsumableItem(healItem item, int slot, bool firstOpenSlot)
        {
            if (!firstOpenSlot)
            {
                if (!consInv.ContainsKey(slot))
                {
                    consInv.Add(slot, item);
                    return true;
                }
                else
                {
                    return false;
                }
            } else
            {
                for (int i = 0; i<MAX_ITEMS; ++i)
                {
                    if (!consInv.ContainsKey(i))
                    {
                        consInv.Add(i, item);
                        return true;
                    }
                }

                return false;
            }
        }

        // Inventory Mover Function
        public void moveItem(ItemCategory cat, int initialSlot, int targetSlot)
        {
            switch (cat)
            {
                case ItemCategory.Equipment:
                    equipmentItem eI = new equipmentItem(equipInv[targetSlot]);
                    equipInv.Remove(targetSlot);
                    equipInv.Add(targetSlot, equipInv[initialSlot]);
                    equipInv.Remove(initialSlot);
                    equipInv.Add(initialSlot, eI);
                    break;
                case ItemCategory.Consumable:
                    healItem hI = new healItem(consInv[targetSlot]);
                    consInv.Remove(targetSlot);
                    consInv.Add(targetSlot, consInv[initialSlot]);
                    consInv.Remove(initialSlot);
                    consInv.Add(initialSlot, hI);
                    break;
                default:
                    break;
            }
        }
    }
}