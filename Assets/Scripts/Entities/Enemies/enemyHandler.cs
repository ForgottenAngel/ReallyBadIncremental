using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;   // Handles Image type.

using BreakInfinity;
using EnemyEnumTables;
using EnemyReferenceTable;

namespace Enemy
{
    public class basicStats
    {
        private BigDouble maxHP;
        private BigDouble currentHP;
        private BigDouble pAttack;
        private BigDouble mAttack;
        private BigDouble pDefense;
        private BigDouble mDefense;

        // Constructor.
        public basicStats()
        {
            maxHP = 50;
            currentHP = maxHP;
            pAttack = 3;
            mAttack = 3;
            pDefense = 2;
            mDefense = 2;
        }

        // General Functions
        public void set(BigDouble mHP, BigDouble pAtk, BigDouble mAtk, BigDouble pDef, BigDouble mDef)
        {
            maxHP = mHP;
            currentHP = maxHP;
            pAttack = pAtk;
            mAttack = mAtk;
            pDefense = pDef;
            mDefense = mDef;
        }

        // Getters and Setters.
        public BigDouble _maxHP
        {
            get { return maxHP; }
        }

        public BigDouble _currentHP
        {
            get { return currentHP; }
            set { currentHP = value; }
        }

        public BigDouble _pAttack
        {
            get { return pAttack; }
        }

        public BigDouble _mAttack
        {
            get { return mAttack; }
        }

        public BigDouble _pDefense
        {
            get { return pDefense; }
        }

        public BigDouble _mDefense
        {
            get { return mDefense; }
        }
    }

    public class enemyHandler
    {
        private Image icon;

        private int level;
        private string name;

        public basicStats enemyStats;
        private EnemyCategory enemyType;

        // Constructor
        public enemyHandler()
        {
            level = 1;
            name = "MISSINGNO.";

            enemyStats = new basicStats();
            enemyType = EnemyCategory.Debug;
        }

        public static implicit operator enemyHandler(enemyInfo info)
        {
            enemyHandler enemy = new enemyHandler();

            enemy.icon = info.icon;

            enemy.level = info.level;
            enemy.name = info.name;

            enemy.enemyStats.set(info.enemyStats.maxHP, info.enemyStats.pAttack, info.enemyStats.mAttack,
                                 info.enemyStats.pDefense, info.enemyStats.mDefense);
            enemy.enemyType = info.enemyType;

            return enemy;
        }

        // Getters and Setters
        public Image _icon
        {
            get { return icon; }
        }

        public int _level
        {
            get { return level; }
        }

        public string _name
        {
            get { return name; }
        }

        public EnemyCategory _enemyType
        {
            get { return enemyType; }
        }
    }
}