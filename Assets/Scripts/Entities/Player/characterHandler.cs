using System.Collections.Generic;

using UnityEngine;

using BreakInfinity;
using Effects;
using StatEnumTables;
using Items;
using ItemEnumTables;

namespace Character
{
    public class basicStats
    {
        private BigDouble bHP;
        private BigDouble bMP;

        private double bStr;   // Strength = Affects PAtk.
        private double bInt;   // Intelligence = Affects MAtk.
        private double bCon;   // Constitution = Affects PDef/HP.
        private double bWil;   // Willpower = Affects MDef/MP.

        // Constructor.
        public basicStats()
        {
            bHP = 200;
            bMP = 50;

            bStr = 1;
            bInt = 1;
            bCon = 1;
            bWil = 1;
        }

        // Getters and Setters.
        public BigDouble _bHP
        {
            get { return bHP; }
            set { bHP = value; }
        }

        public BigDouble _bMP
        {
            get { return bMP; }
            set { bMP = value; }
        }

        public double _bStr
        {
            get { return bStr; }
            set { bStr = value; }
        }

        public double _bInt
        {
            get { return bInt; }
            set { bInt = value; }
        }

        public double _bCon
        {
            get { return bCon; }
            set { bCon = value; }
        }

        public double _bWil
        {
            get { return bWil; }
            set { bWil = value; }
        }
    }

    public class derivativeStats
    {
        private BigDouble maxHP;
        private BigDouble currHP;
        private BigDouble maxMP;
        private BigDouble currMP;
        private BigDouble pAttack;
        private BigDouble mAttack;
        private BigDouble pDefense;
        private BigDouble mDefense;

        private double totalStr;
        private double totalInt;
        private double totalCon;
        private double totalWil;

        // Constructor.
        public derivativeStats()
        {
            maxHP = 200;
            currHP = maxHP;
            maxMP = 50;
            currMP = maxMP;
            pAttack = 10;
            mAttack = 10;
            pDefense = 10;
            mDefense = 10;

            totalStr = 1;
            totalInt = 1;
            totalCon = 1;
            totalWil = 1;
        }

        // Getters and Setters.
        public BigDouble _maxHP
        {
            get { return maxHP; }
            set { maxHP = value; }
        }

        public BigDouble _currHP
        {
            get { return currHP; }
            set { currHP = value; }
        }

        public BigDouble _maxMP
        {
            get { return maxMP; }
            set { maxMP = value; }
        }

        public BigDouble _currMP
        {
            get { return currMP; }
            set { currMP = value; }
        }

        public BigDouble _pAttack
        {
            get { return pAttack; }
            set { pAttack = value; }
        }

        public BigDouble _mAttack
        {
            get { return mAttack; }
            set { mAttack = value; }
        }

        public BigDouble _pDefense
        {
            get { return pDefense; }
            set { pDefense = value; }
        }

        public BigDouble _mDefense
        {
            get { return mDefense; }
            set { mDefense = value; }
        }

        public double _totalStr
        {
            get { return totalStr; }
            set { totalStr = value; }
        }

        public double _totalInt
        {
            get { return totalInt; }
            set { totalInt = value; }
        }

        public double _totalCon
        {
            get { return totalCon; }
            set { totalCon = value; }
        }

        public double _totalWil
        {
            get { return totalWil; }
            set { totalWil = value; }
        }
    }

    public class specializedStats
    {
        private float criticalRate;
        private float criticalDamage;
        private long accuracy;
        private float hitRate;
        private long avoidability;
        private float dodgeRate;
        private float blockRate;

        // Consturctor.
        public specializedStats()
        {
            criticalRate = 0.00f;
            criticalDamage = 1.50f;
            accuracy = 0;
            hitRate = 0.00f;
            avoidability = 0;
            dodgeRate = 0.00f;
            blockRate = 0.00f;
        }

        // Getters and Setters
        public float _criticalRate
        {
            get { return criticalRate; }
            set { criticalRate = value; }
        }

        public float _criticalDamage
        {
            get { return criticalDamage; }
            set { criticalDamage = value; }
        }

        public long _accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }

        public float _hitRate
        {
            get { return hitRate; }
            set { hitRate = value; }
        }

        public long _avoidability
        {
            get { return avoidability; }
            set { avoidability = value; }
        }

        public float _dodgeRate
        {
            get { return dodgeRate; }
            set { dodgeRate = value; }
        }

        public float _blockRate
        {
            get { return blockRate; }
            set { blockRate = value; }
        }
    }

    public class statMultipliers
    {
        private float hpM;
        private float mpM;
        private float strM;
        private float intM;
        private float conM;
        private float wilM;
        private float pAtkM;
        private float mAtkM;
        private float pDefM;
        private float mDefM;

        // Constructor.
        public statMultipliers()
        {
            hpM = 1.00f;
            mpM = 1.00f;
            strM = 1.00f;
            intM = 1.00f;
            conM = 1.00f;
            wilM = 1.00f;
            pAtkM = 1.00f;
            mAtkM = 1.00f;
            pDefM = 1.00f;
            mDefM = 1.00f;
        }

        // Getters and Setters
        public float _hpM
        {
            get { return hpM; }
            set { hpM = value; }
        }

        public float _mpM
        {
            get { return mpM; }
            set { mpM = value; }
        }

        public float _strM
        {
            get { return strM; }
            set { strM = value; }
        }

        public float _intM
        {
            get { return intM; }
            set { intM = value; }
        }

        public float _conM
        {
            get { return conM; }
            set { conM = value; }
        }

        public float _wilM
        {
            get { return wilM; }
            set { wilM = value; }
        }

        public float _pAtkM
        {
            get { return pAtkM; }
            set { pAtkM = value; }
        }

        public float _mAtkM
        {
            get { return mAtkM; }
            set { mAtkM = value; }
        }

        public float _pDefM
        {
            get { return pDefM; }
            set { pDefM = value; }
        }

        public float _mDefM
        {
            get { return mDefM; }
            set { mDefM = value; }
        }
    }

    public sealed class characterHandler
    {
        // Basic Character Stats.
        private int level;
        private BigDouble currentEXP;
        private BigDouble toNextLevelEXP;
        private BigDouble totalEXP;

        private string charName;

        public basicStats baseStats;
        public derivativeStats derivedStats;
        public specializedStats specialStats;
        public statMultipliers statMultis;
        private long statPoints;

        // Character Inventory.
        private BigDouble money;
        private Dictionary<EquipmentSlot, equipmentItem> equipment;

        // Character Flags.
        private bool inCombat;

        public Dictionary<int, int> abilityList;

        // Class Functions.
        // Initialization
        public characterHandler()
        {
            level = 1;
            currentEXP = 0;
            toNextLevelEXP = 102;
            totalEXP = 0;

            charName = "[REDACTED]";

            // Initialize Stats
            baseStats = new basicStats();
            derivedStats = new derivativeStats();
            specialStats = new specializedStats();
            statMultis = new statMultipliers();
            statPoints = 0;

            // Initialize Inventory
            money = 0;
            equipment = new Dictionary<EquipmentSlot, equipmentItem>();

            // Intialize Derived Stats
            updateStats();

            initAbilies(out abilityList);
        }

        // Ability List Initializer
        private void initAbilies(out Dictionary<int, int> a)
        {
            a = new Dictionary<int, int>();
            a.Add(0, 0);
            a.Add(1, 1);
        }

        // Handle Player Equipment
        public void changeEquip(ref equipmentItem item)
        {
            equipmentItem equippedItem = new equipmentItem(item);

            if (equipment.ContainsKey(item._equipSlot))
            {
                item.copy(equipment[item._equipSlot]);
                equipment.Remove(item._equipSlot);
            } else
            {
                item = null;
            }

            equipment.Add(equippedItem._equipSlot, equippedItem);
        }

        // Updates the derived stats.
        public void updateStats()
        {
            derivedStats._maxHP = baseStats._bHP * statMultis._hpM;
            derivedStats._maxMP = baseStats._bMP * statMultis._mpM;
            derivedStats._totalStr = baseStats._bStr * statMultis._strM;
            derivedStats._totalInt = baseStats._bInt * statMultis._intM;
            derivedStats._totalCon = baseStats._bCon * statMultis._conM;
            derivedStats._totalWil = baseStats._bWil * statMultis._wilM;

            if (derivedStats._currHP > derivedStats._maxHP)
            {
                derivedStats._currHP = derivedStats._maxHP;
            }

            if (derivedStats._currMP > derivedStats._maxMP)
            {
                derivedStats._currMP = derivedStats._maxMP;
            }
        }

        // Function to add EXP to character.
        public void incrementEXP(BigDouble expGained)
        {
            currentEXP += expGained;
            totalEXP += expGained;

            updateLevel();
        }

        // Handles Level Up Math
        public void updateLevel()
        {
            while (currentEXP >= toNextLevelEXP)
            {
                level += 1;
                currentEXP -= toNextLevelEXP;

                // EXP tNL Formula:
                // EXPtNL = floor[100 * (1.023 ^ level) * (level ^ 1.02)]
                toNextLevelEXP = BigDouble.Floor(100 * BigDouble.Pow(1.023, level) * BigDouble.Pow(level, 1.02));
            }
        }

        // Handles Stat Distribution
        public void applyStatPoints(StatType type, long amount)
        {
            if (amount > statPoints || amount <= 0)
            {
                // Place a warning popup here or something.
            } else {
                switch (type)
                {
                    case StatType.Strength:
                        baseStats._bStr += amount;
                        break;
                    case StatType.Intelligence:
                        baseStats._bInt += amount;
                        break;
                    case StatType.Constitution:
                        baseStats._bCon += amount;
                        break;
                    case StatType.Willpower:
                        baseStats._bWil += amount;
                        break;
                }

                statPoints -= amount;
            }
        }

        #region characterHandler Getters and Setters
        // Getters and Setters
        public int _level
        {
            get { return level; }
        }

        public BigDouble _currentEXP
        {
            get { return currentEXP; }
        }

        public BigDouble _toNextLevelEXP
        {
            get { return toNextLevelEXP; }
        }

        public BigDouble _totalEXP
        {
            get { return totalEXP; }
        }

        public string _charname
        {
            get { return charName; }
            set { charName = value; }
        }

        public long _statPoints
        {
            get { return statPoints; }
        }

        public BigDouble _money
        {
            get { return money; }
        }

        public bool _inCombat
        {
            get { return inCombat; }
            set { inCombat = value; }
        }
        #endregion
    }
}