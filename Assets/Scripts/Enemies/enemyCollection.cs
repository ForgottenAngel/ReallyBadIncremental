using System.Collections;
using System.Collections.Generic;

using UnityEngine.UI;   // Handles Image type.

using BreakInfinity;
using EnemyEnumTables;

namespace EnemyReferenceTable
{
    public readonly struct enemyStatValues
    {
        public BigDouble maxHP { get; }
        public BigDouble pAttack { get; }
        public BigDouble mAttack { get; }
        public BigDouble pDefense { get; }
        public BigDouble mDefense { get; }

        public enemyStatValues(BigDouble mHP, BigDouble pAtk, BigDouble mAtk, BigDouble pDef, BigDouble mDef)
        {
            maxHP = mHP;
            pAttack = pAtk;
            mAttack = mAtk;
            pDefense = pDef;
            mDefense = mDef;
        }
    }

    public readonly struct enemyInfo
    {
        public Image icon { get; }

        public int level { get; }
        public string name { get; }
        public EnemyCategory enemyType { get; }
        public enemyStatValues enemyStats { get; }

        public enemyInfo(Image i, int lvl, string n, EnemyCategory type, enemyStatValues eSV)
        {
            icon = i;
            level = lvl;
            name = n;
            enemyType = type;
            enemyStats = eSV;
        }
    }

    public class EnemyCollection
    {
        Dictionary<int, enemyInfo> enemyList = new Dictionary<int, enemyInfo>();

        // Constructor.
        public EnemyCollection()
        {
            enemyList.Add(0, enemy0);
        }

        // Enemy Definitions.

        // #0000: Debug Enemy (Debug)
        // HP: 20 | P.Attack: 1 | M.Attack: 1 | P.Defense: 0 | M.Defense: 0
        enemyInfo enemy0 = new enemyInfo(null, 1, "Debug Enemy", EnemyCategory.Debug, 
                                         new enemyStatValues(20, 1, 1, 0, 0));
    }
}