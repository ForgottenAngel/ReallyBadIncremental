using System;
using System.Collections;
using System.Collections.Generic;

using ItemEnumTables;
using Items;

namespace Inventory
{
    public struct Constants
    {
        public const int ITEMS_PER_PAGE = 25;
        public const int MAX_PAGES = 20;
    }

    public class equipHandler
    {
        private List<equipmentItem> charEquips = new List<equipmentItem>();
    }

    public class inventoryHandler
    {
        private List<equipmentItem> equipInv = new List<equipmentItem>();
    }
}