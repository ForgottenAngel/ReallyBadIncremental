using System.Collections.Generic;

using UnityEngine;

using BreakInfinity;
using Effects;

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
        private BigDouble maxMP;
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
            maxMP = 50;
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

        public BigDouble _maxMP
        {
            get { return maxMP; }
            set { maxMP = value; }
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

    public sealed class characterHandler : MonoBehaviour
    {
        // Basic Character Stats.
        private int level;
        private string charName;

        public basicStats baseStats;
        public derivativeStats derivedStats;
        public specializedStats specialStats;
        public statMultipliers statMultis;

        // Character Inventory.
        private BigDouble money;

        // Character Flags.
        private bool inCombat;

        // Class Functions.
        // Initialization
        public characterHandler()
        {
            level = 1;
            charName = "[REDACTED]";

            // Initialize Stat Structures
            baseStats = new basicStats();
            derivedStats = new derivativeStats();
            specialStats = new specializedStats();
            statMultis = new statMultipliers();

            // Intialize Derived Stats
            updateStats();
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
        }

    }
}