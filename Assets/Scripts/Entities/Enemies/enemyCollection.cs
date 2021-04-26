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
        public BigDouble exp { get; }
        public List<int> abilities { get; }

        public enemyInfo(Image i, int lvl, string n, EnemyCategory type, enemyStatValues eSV, BigDouble xp, List<int> a)
        {
            icon = i;
            level = lvl;
            name = n;
            enemyType = type;
            enemyStats = eSV;
            exp = xp;
            abilities = a;
        }
    }

    public class enemyCollection
    {
        public Dictionary<int, enemyInfo> enemyList;

        // Constructor.
        public enemyCollection()
        {
            defineEnemies(out enemyList);
        }

        public void defineEnemies(out Dictionary<int, enemyInfo> eL)
        {
            eL = new Dictionary<int, enemyInfo>();

            // Enemy Definitions.   

            // #0000: Debug Enemy (Debug)
            // HP: 20 | P.Attack: 1 | M.Attack: 1 | P.Defense: 0 | M.Defense: 0
            // Abilities: 0, 1
            List<int> abil0 = new List<int>();
            abil0.Add(0);
            abil0.Add(1);
            enemyInfo enemy0 = new enemyInfo(null, 1, "Debug Enemy", EnemyCategory.Debug,
                                             new enemyStatValues(20, 2, 1, 0, 0), 10, abil0);
            eL.Add(0, enemy0);
        }
    }
}