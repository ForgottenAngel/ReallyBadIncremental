using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;   // Handles Image type.

using BreakInfinity;
using ItemEnumTables;

namespace Items
{
    // Structs to hold groupings of stats.
    public class statReqs 
    {
        private double strR;
        private double intR;
        private double conR;
        private double wilR;

        // Constructor.
        public statReqs()
        {
            strR = 0;
            intR = 0;
            conR = 0;
            wilR = 0;
        }

        // Functions
        public void set(double s, double i, double c, double w)
        {
            strR = s;
            intR = i;
            conR = c;
            wilR = w;
        }

        // Getters and Setters
        public double _strR
        {
            get { return strR; }
        }

        public double _intR
        {
            get { return intR; }
        }

        public double _conR
        {
            get { return conR; }
        }

        public double _wilR
        {
            get { return wilR; }
        }
    }

    public class baseStatGains
    {
        private double pAtkG;
        private double mAtkG;

        private double pDefG;
        private double mDefG;

        private double strG;
        private double intG;
        private double conG;
        private double wilG;

        // Constructor.
        public baseStatGains()
        {
            pAtkG = 0;
            mAtkG = 0;

            pDefG = 0;
            mDefG = 0;

            strG = 0;
            intG = 0;
            conG = 0;
            wilG = 0;
        }

        // General Functions.
        public void setAtk(double pAtk, double mAtk)
        {
            pAtkG = pAtk;
            mAtkG = mAtk;
        }

        public void setDef(double pDef, double mDef)
        {
            pDefG = pDef;
            mDefG = mDef;
        }

        public void setStats(double s, double i, double c, double w)
        {
            strG = s;
            intG = i;
            conG = c;
            wilG = w;
        }

        // Setters and Getters.
        public double _pAtkG
        {
            get { return pAtkG; }
        }

        public double _mAtkG
        {
            get { return mAtkG; }
        }

        public double _pDefG
        {
            get { return pDefG; }
        }

        public double _mDefG
        {
            get { return mDefG; }
        }

        public double _strG
        {
            get { return strG; }
        }

        public double _intG
        {
            get { return intG; }
        }

        public double _conG
        {
            get { return conG; }
        }

        public double _wilG
        {
            get { return wilG; }
        }
    }

    public class specialStatGains
    {
        private float critRateG;
        private float critDamageG;
        private long accG;
        private float hitRateG;
        private long avoidG;
        private float dodgeG;
        private float blockG;

        // Constructor.
        public specialStatGains()
        {
            critRateG = 0.00f;
            critDamageG = 0.00f;
            accG = 0;
            hitRateG = 0.00f;
            avoidG = 0;
            dodgeG = 0.00f;
            blockG = 0.00f;
        }

        // Getters and Setters
        public float _critRateG
        {
            get { return critRateG; }
            set { critRateG = value; }
        }

        public float _critDamageG
        {
            get { return critDamageG; }
            set { critDamageG = value; }
        }

        public long _accG
        {
            get { return accG; }
            set { accG = value; }
        }

        public float _hitRateG
        {
            get { return hitRateG; }
            set { hitRateG = value; }
        }

        public long _avoidG
        {
            get { return avoidG; }
            set { avoidG = value; }
        }

        public float _dodgeG
        {
            get { return dodgeG; }
            set { dodgeG = value; }
        }

        public float _blockG
        {
            get { return blockG; }
            set { blockG = value; }
        }
    }

    // Defines a basic item class to derive specialized classes from.
    public abstract class itemObject
    {
        // Basic Item Variables.
        protected Image icon;

        protected int itemID;
        protected ItemCategory itemCat;

        protected string itemName;
        protected string itemDesc;
        protected ItemRarityTier itemRarity;
        
        protected bool isSellable;
        protected BigDouble itemValue;

        protected bool isLocked;

        // Common Item Functions.
        public void toggleLock() {
            isLocked = !isLocked;
        }

        // Common Getters and Setters
        public Image _icon
        {
            get { return icon; }
            set { icon = value; }
        }

        public int _itemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public ItemCategory _itemCat
        {
            get { return itemCat; }
        }

        public string _itemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string _itemDesc
        {
            get { return itemDesc; }
            set { itemDesc = value; }
        }

        public ItemRarityTier _itemRarity
        {
            get { return itemRarity; }
            set { itemRarity = value; }
        }

        public bool _isSellable
        {
            get { return isSellable; }
            set { isSellable = value; }
        }

        public BigDouble _itemValue
        {
            get { return itemValue; }
            set { itemValue = value; }
        }
    }

    // Defines the equipment item class.
    public class equipmentItem : itemObject
    {
        private EquipmentSlot equipSlot;

        private int levelReq;
        private statReqs equipReqs;
        private baseStatGains baseEquipStats;
        private specialStatGains equipSpecialStats;

        public equipmentItem()
        {
            // Intialize itemObject variables.
            icon = null;

            itemID = 0;
            itemCat = ItemCategory.Equipment;

            itemName = "Suspiciously Unnamed Item";
            itemDesc = @"For whatever reason, this item has no description.
                         Please report this to your nearest overworked dev.
                         Thank you.";
            itemRarity = ItemRarityTier.Debug;

            isSellable = false;
            itemValue = 0;

            isLocked = false;

            // Initialize equipmentItem variables.
            levelReq = 1;
            equipSlot = EquipmentSlot.Debug;
            equipReqs = new statReqs();
            baseEquipStats = new baseStatGains();
            equipSpecialStats = new specialStatGains();
        }

        // equipmentItem getters and setters.
        public EquipmentSlot _equipSlot
        {
            get { return equipSlot; }
            set { equipSlot = value; }
        }

        public int _levelReq
        {
            get { return levelReq; }
            set { levelReq = value; }
        }

        public statReqs _equipReqs
        {
            get { return equipReqs; }
        }

        public baseStatGains _baseEquipStats
        {
            get { return baseEquipStats; }
        }

        public specialStatGains _equipSpecialStats
        {
            get { return equipSpecialStats; }
        }
    }
}