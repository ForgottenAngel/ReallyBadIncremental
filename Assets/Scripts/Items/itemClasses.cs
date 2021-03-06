﻿using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;   // Handles Image type.

using BreakInfinity;
using ItemEnumTables;
using ItemReferenceTable;

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

        // Copy Constructor
        public statReqs(statReqs reqs)
        {
            strR = reqs.strR;
            intR = reqs.intR;
            conR = reqs.conR;
            wilR = reqs.wilR;
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
        
        // Copy Constructor
        public baseStatGains(baseStatGains gains)
        {
            pAtkG = gains.pAtkG;
            mAtkG = gains.mAtkG;

            pDefG = gains.pDefG;
            mDefG = gains.mDefG;

            strG = gains.strG;
            intG = gains.intG;
            conG = gains.conG;
            wilG = gains.wilG;
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

        public specialStatGains(specialStatGains gains)
        {
            critRateG = gains.critRateG;
            critDamageG = gains.critDamageG;
            accG = gains.accG;
            hitRateG = gains.hitRateG;
            avoidG = gains.avoidG;
            dodgeG = gains.dodgeG;
            blockG = gains.blockG;
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
        protected int icon;

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
        public int _icon
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
            icon = 0;

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

        // Copy Constructor
        public equipmentItem(equipmentItem item)
        {
            equipItemObjValCopy(item);
            equipReqs = new statReqs(item.equipReqs);
            baseEquipStats = new baseStatGains(item.baseEquipStats);
            equipSpecialStats = new specialStatGains(item.equipSpecialStats);
        }

        // Copies WITHOUT creating a new instance.
        public void copy(equipmentItem item)
        {
            equipItemObjValCopy(item);
            equipReqs = item.equipReqs;
            baseEquipStats = item.baseEquipStats;
            equipSpecialStats = item.equipSpecialStats;
        }

        // Seperate basic var copy to reuse code.
        private void equipItemObjValCopy(equipmentItem item)
        {
            // Copy itemObject variables.
            icon = item.icon;

            itemID = item.itemID;
            itemCat = item.itemCat;

            itemName = item.itemName;
            itemDesc = item.itemDesc;
            itemRarity = item.itemRarity;

            isSellable = item.isSellable;
            itemValue = item.itemValue;

            isLocked = item.isLocked;

            // Copy equipmentItem variables.
            levelReq = item.levelReq;
            equipSlot = item.equipSlot;
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

        // Implicit conversion from info to item for item generation.
        public static implicit operator equipmentItem(equipItemInfo info)
        {
            equipmentItem item = new equipmentItem();

            // Set basic info.
            item.equipSlot = info.equipSlot;
            item.levelReq = info.levelReq;

            item.icon = info.itemInfo.icon;

            item.itemID = info.itemInfo.itemID;
            item.itemCat = info.itemInfo.itemCat;

            item.itemName = info.itemInfo.itemName;
            item.itemDesc = info.itemInfo.itemDesc;
            item.itemRarity = info.itemInfo.itemRarity;

            item.isSellable = info.itemInfo.isSellable;
            item.itemValue = info.itemInfo.itemValue;

            // Set Equip Requiremenst
            item.equipReqs.set(info.equipReqs.strR, info.equipReqs.intR, info.equipReqs.conR, info.equipReqs.wilR);

            // Set Equip Stats
            item.baseEquipStats.setAtk(info.baseEquipStats.pAtkG, info.baseEquipStats.mAtkG);
            item.baseEquipStats.setDef(info.baseEquipStats.pDefG, info.baseEquipStats.mDefG);
            item.baseEquipStats.setStats(info.baseEquipStats.strG, info.baseEquipStats.intG, info.baseEquipStats.conG, info.baseEquipStats.wilG);

            // Set Equip Special Stats
            item.equipSpecialStats._critRateG = info.specialEquipStats.critRateG;
            item.equipSpecialStats._critDamageG = info.specialEquipStats.critDamageG;
            item.equipSpecialStats._accG = info.specialEquipStats.accG;
            item.equipSpecialStats._hitRateG = info.specialEquipStats.hitRateG;
            item.equipSpecialStats._avoidG = info.specialEquipStats.avoidG;
            item.equipSpecialStats._dodgeG = info.specialEquipStats.dodgeG;
            item.equipSpecialStats._blockG = info.specialEquipStats.blockG;

            return item;
        }
    }

    // Defines the consumable item class.
    public class healItem : itemObject
    {
        private ConsumableType type;

        private int levelReq;
        private BigDouble hpHealAmount;
        private bool hpPercentHeal;
        private BigDouble mpHealAmount;
        private bool mpPercentHeal;

        // Constructor
        public healItem()
        {
            // Intialize itemObject variables.
            icon = 0;

            itemID = 0;
            itemCat = ItemCategory.Consumable;

            itemName = "Suspiciously Unnamed Item";
            itemDesc = @"For whatever reason, this item has no description.
                         Please report this to your nearest overworked dev.
                         Thank you.";
            itemRarity = ItemRarityTier.Debug;

            isSellable = false;
            itemValue = 0;

            isLocked = false;

            // Initialize healItem variables.
            type = ConsumableType.Heal;

            levelReq = 0;
            hpHealAmount = 1;
            hpPercentHeal = false;
            mpHealAmount = 1;
            mpPercentHeal = false;
        }

        // Copy Consturctor
        public healItem(healItem item)
        {
            type = item.type;
            levelReq = item.levelReq;
            hpHealAmount = item.hpHealAmount;
            hpPercentHeal = item.hpPercentHeal;
            mpHealAmount = item.mpHealAmount;
            mpPercentHeal = item.mpPercentHeal;
        }

        // Getters and Setters
        public ConsumableType _type
        {
            get { return type; }
        }

        public int _levelReq
        {
            get { return levelReq; }
        }

        public BigDouble _hpHealAmount
        {
            get { return hpHealAmount; }
        }

        public bool _hpPercentHeal
        {
            get { return hpPercentHeal; }
        }

        public BigDouble _mpHealAmount
        {
            get { return mpHealAmount; }
        }

        public bool _mpPercentHeal
        {
            get { return mpPercentHeal; }
        }

        public static implicit operator healItem(healItemInfo info)
        {
            healItem item = new healItem();

            // Set basic info.
            item.icon = info.itemInfo.icon;

            item.itemID = info.itemInfo.itemID;
            item.itemCat = info.itemInfo.itemCat;

            item.itemName = info.itemInfo.itemName;
            item.itemDesc = info.itemInfo.itemDesc;
            item.itemRarity = info.itemInfo.itemRarity;

            item.isSellable = info.itemInfo.isSellable;
            item.itemValue = info.itemInfo.itemValue;

            // Set healItem info.
            item.type = info.consType;

            item.levelReq = info.levelReq;
            item.hpHealAmount = info.hpHealAmount;
            item.hpPercentHeal = info.hpPercentHeal;
            item.mpHealAmount = info.mpHealAmount;
            item.mpPercentHeal = info.mpPercentHeal;

            return item;
        }

    }
}