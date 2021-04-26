﻿using System;
using System.Collections.Generic;

using ItemEnumTables;


namespace LootReferenceTable
{
    public class lootTableCollection
    {
        Dictionary<int, List<Tuple<ItemCategory, int, float>>> dropTableList;

        public lootTableCollection()
        {
            defineLootTables(out dropTableList);
        }

        private void defineLootTables(out Dictionary<int, List<Tuple<ItemCategory, int, float>>> dTL)
        {
            dTL = new Dictionary<int, List<Tuple<ItemCategory, int, float>>>();

            List<Tuple<ItemCategory, int, float>> table0 = new List<Tuple<ItemCategory, int, float>>();
            table0.Add(Tuple.Create(ItemCategory.Equipment, 0, 0.25f));
            table0.Add(Tuple.Create(ItemCategory.Consumable, 0, 0.10f));
            dTL.Add(0, table0);
        }
       
    }
}
