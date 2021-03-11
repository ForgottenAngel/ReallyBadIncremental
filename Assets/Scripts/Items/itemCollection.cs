using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;   // Handles Image type.

using ItemEnumTables;
using BreakInfinity;

using Items;

namespace ItemReferenceTable
{
    // Informational Structs to hold massive quantities of RO data.
    public readonly struct baseItemInfo
    {
        public Image icon { get; }
        
        public int itemID { get; }
        public ItemCategory itemCat { get; }

        public string itemName { get; }
        public string itemDesc { get; }
        public ItemRarityTier itemRarity { get; }

        public bool isSellable { get; }
        public BigDouble itemValue { get; }

        // Construtor.
        public baseItemInfo(Image ico, int iID, ItemCategory ic, string name, string desc, 
                            ItemRarityTier ir, bool sell, BigDouble val)
        {
            icon = ico;

            itemID = iID;
            itemCat = ic;

            itemName = name;
            itemDesc = desc;
            itemRarity = ir;

            isSellable = sell;
            itemValue = val;
        }
    }

    // Equipment Structs
    #region Equipment Structs
    public readonly struct statRequirements
    {
        public double strR { get; }
        public double intR { get; }
        public double conR { get; }
        public double wilR { get; }

        // Construtor.
        public statRequirements(double s, double i, double c, double w)
        {
            strR = s;
            intR = i;
            conR = c;
            wilR = w;
        }
    }

    public readonly struct baseStats
    {
        public double pAtkG { get; }
        public double mAtkG { get; }

        public double pDefG { get; }
        public double mDefG { get; }

        public double strG { get; }
        public double intG { get; }
        public double conG { get; }
        public double wilG { get; }

        // Construtor.
        public baseStats(double pa, double ma, double pd, double md, 
                         double s, double i, double c, double w)
        {
            pAtkG = pa;
            mAtkG = ma;

            pDefG = pd;
            mDefG = md;

            strG = s;
            intG = i;
            conG = c;
            wilG = w;
        }
    }

    public readonly struct specialStats
    {
        public float critRateG { get; }
        public float critDamageG { get; }
        public long accG { get; }
        public float hitRateG { get; }
        public long avoidG { get; }
        public float dodgeG { get; }
        public float blockG { get; }

        // Construtor.
        public specialStats(float crate, float cdmg, long acc, float hrate, 
                            long avd, float dge, float blk)
        {
            critRateG = crate;
            critDamageG = cdmg;
            accG = acc;
            hitRateG = hrate;
            avoidG = avd;
            dodgeG = dge;
            blockG = blk;
        }
    }

    public readonly struct equipItemInfo
    {
        public EquipmentSlot equipSlot { get; }

        public int levelReq { get; }
        public baseItemInfo itemInfo { get; }
        public statRequirements equipReqs { get; }
        public baseStats baseEquipStats { get; }
        public specialStats specialEquipStats { get; }

        // Construtor.
        public equipItemInfo(EquipmentSlot es, int level, baseItemInfo info,
                             statRequirements sr, baseStats bs, specialStats ss)
        {
            equipSlot = es;

            levelReq = level;
            itemInfo = info;
            equipReqs = sr;
            baseEquipStats = bs;
            specialEquipStats = ss;
        }
    }
    #endregion

    // Consumable Structs
    #region Consumable Structs
    public readonly struct healItemInfo
    {
        public ConsumableType consType { get; }

        public int levelReq { get; }
        public baseItemInfo itemInfo { get; }

        public BigDouble hpHealAmount { get; }
        public bool hpPercentHeal { get; }
        public BigDouble mpHealAmount { get; }
        public bool mpPercentHeal { get; }

        // Constructor.
        public healItemInfo(int level, baseItemInfo info, BigDouble hpHeal, bool hpPerc, BigDouble mpHeal, bool mpPerc)
        {
            consType = ConsumableType.Heal;

            levelReq = level;
            itemInfo = info;

            hpHealAmount = hpHeal;
            hpPercentHeal = hpPerc;
            mpHealAmount = mpHeal;
            mpPercentHeal = mpPerc;
        }
    }
    #endregion

    public class itemCollection
    {
        Dictionary<int, equipItemInfo> equipmentList = new Dictionary<int, equipItemInfo>();
        Dictionary<int, healItemInfo> healItemList = new Dictionary<int, healItemInfo>();

        // Construtor
        public itemCollection()
        {
            // Equipment List Init.
            equipmentList.Add(0, equip0);
        }

        // Item Definitions

        // Healing Consumable Definitions

        // #0000: THE Mountain Dew
        // Level Req: 1 | Rarity: Debug | Unsellable | Value: 420g 
        // Heals >> HP: 110% | MP: 110%
        healItemInfo healItem0 = new healItemInfo(1, new baseItemInfo(null, 0, ItemCategory.Consumable, "THE Mountain Dew",
                                                                      "The fabled dew from the peak of the mountain.",
                                                                      ItemRarityTier.Debug, false, 420),
                                                  110, true, 110, true);

        // Equipment Definitions.

        // #0000: ??? Weapon (Main Hand)
        // Level Req: 1 | Rarity: Debug | Unsellable | Value: 42069g
        // Requires >> Str: 1 | Int: 1 | Con: 1 | Wil: 1
        // Provides >> P.Atk: 2 | M.Atk: 2 | P.Def: 0 | M.Def: 0 | Str: 1 | Int: 1 | Con: 1 | Wil: 1
        //          >> Crit.Rate: 10% | Crit.Dmg: 0% | Accuracy: 0 | Hit Rate: 50% | Avoid: 0 | Dodge: 10% | Block: 15%
        equipItemInfo equip0 = new equipItemInfo(EquipmentSlot.MainHand, 1, new baseItemInfo(null, 0, ItemCategory.Equipment, "??? Weapon", 
                                                                                             "A spooky unknown weapon...or so you think...", 
                                                                                             ItemRarityTier.Debug, false, 42069), 
                                                                            new statRequirements(1, 1, 1, 1),
                                                                            new baseStats(2, 2, 0, 0, 1, 1, 1, 1),
                                                                            new specialStats(10f, 0f, 0, 50f, 0, 10f, 15f));
    }
}
