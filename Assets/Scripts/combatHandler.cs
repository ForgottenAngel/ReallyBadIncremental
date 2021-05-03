using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;
using BreakInfinity;

using Character;
using Enemy;
using EnemyReferenceTable;
using Abilities;
using AbilityEnumTables;
using LootReferenceTable;
using ItemEnumTables;
using ItemReferenceTable;
using Items;

namespace Combat
{
    public class combatHandler
    {
        private bool combatActive;
        private abilitiesCollection abilities = new abilitiesCollection();
        private enemyCollection enemies = new enemyCollection();
        public enemyHandler enemy = new enemyHandler();
        private lootTableCollection loot = new lootTableCollection();
        private itemCollection items = new itemCollection();

        public combatHandler()
        {
            abilities = new abilitiesCollection();
            enemies = new enemyCollection();
            enemy = new enemyHandler();
        }

        public void spawnEnemy(int enemyID)
        {
            enemy = enemies.enemyList[enemyID];
            combatActive = true;
        }

        public bool checkEnemyAlive()
        {
            if (enemy.enemyStats._currentHP <= 0)
            {
                combatActive = false;
                return false;
            } else
            {
                return true;
            }
        }

        public void doAbility(characterHandler player, int abilityID, bool enemyAction)
        {
            BigDouble dmgVal = abilities.abilityList[abilityID].Invoke();
            abilityScaling scaling = abilities.abilityInfoList[abilityID].scaling;
            AbilityType type = abilities.abilityInfoList[abilityID].type;
            bool healing = abilities.abilityInfoList[abilityID].isHeal;

            // Determine ability user.
            if (enemyAction == false)
            {
                // Apply stat scaling to base value.
                dmgVal *= (player.derivedStats._totalStr * scaling.strScale) + (player.derivedStats._totalInt * scaling.intScale)
                          + (player.derivedStats._totalCon * scaling.conScale) + (player.derivedStats._totalWil * scaling.wilScale)
                          + (player.derivedStats._pAttack * scaling.pAtkScale) + (player.derivedStats._mAttack * scaling.mAtkScale);

                // Handle Buffs + Debuffs
                if (type == AbilityType.Buff || type == AbilityType.Debuff)
                {
                    List<int> effects = new List<int>();
                    effects = abilities.abilEffectList[abilityID].Invoke();

                    if (type == AbilityType.Buff)
                    {
                        for (int i = 0; i < effects.Count; ++i)
                        {

                        }
                    }
                    else if (type == AbilityType.Debuff)
                    {

                    }
                }

                // Handle Healing or Damage
                if (type == AbilityType.Healing || healing == true)
                {
                    if (player.derivedStats._currHP + dmgVal > player.derivedStats._maxHP)
                    {
                        player.derivedStats._currHP = player.derivedStats._maxHP;
                    }
                    else
                    {
                        player.derivedStats._currHP += dmgVal;
                    }
                }
                else
                {
                    enemy.enemyStats._currentHP -= dmgVal;
                }
            }
            else if (enemyAction == true && combatActive == true)
            {
                // Apply stat scaling to base value.
                dmgVal *= (enemy.enemyStats._pAttack * 4 * scaling.strScale) + (enemy.enemyStats._mAttack * 4 * scaling.intScale)
                          + (enemy.enemyStats._pDefense * 4 * scaling.conScale) + (enemy.enemyStats._mDefense * 4 * scaling.wilScale)
                          + (enemy.enemyStats._pAttack * scaling.pAtkScale) + (enemy.enemyStats._mAttack * scaling.mAtkScale);

                // Handle Buffs + Debuffs
                if (type == AbilityType.Buff || type == AbilityType.Debuff)
                {
                    List<int> effects = new List<int>();
                    effects = abilities.abilEffectList[abilityID].Invoke();

                    if (type == AbilityType.Buff)
                    {
                        for (int i = 0; i < effects.Count; ++i)
                        {

                        }
                    }
                    else if (type == AbilityType.Debuff)
                    {

                    }
                }

                // Handle Healing or Damage
                if (type == AbilityType.Healing)
                {
                    if (enemy.enemyStats._currentHP + dmgVal > enemy.enemyStats._maxHP)
                    {
                        enemy.enemyStats._currentHP = enemy.enemyStats._maxHP;
                    }
                    else
                    {
                        enemy.enemyStats._currentHP += dmgVal;
                    }
                }
                else
                {
                    player.derivedStats._currHP -= dmgVal;
                }
            }
        }

        public void calculateDrops(characterHandler player)
        {
            // RNG To roll for drops.
            System.Random rng = new System.Random();

            // Iterate through all drop tables, and the contents of said drop tables, roll for loot.
            for (int i = 0; i < enemy.drops.Count; ++i)
            {
                for (int j = 0; j < loot.dropTableList[enemy.drops[i]].Count; ++j)
                {
                    if (rng.NextDouble() <= loot.dropTableList[enemy.drops[i]][j].Item3)
                    {
                        switch (loot.dropTableList[enemy.drops[i]][j].Item1)
                        {
                            case ItemCategory.Equipment:
                                player.inventory.AddEquipItem(items.equipmentList[loot.dropTableList[enemy.drops[i]][j].Item2], 0, true);
                                break;
                        }
                    }
                }
            }
        }

        public bool _combatActive
        {
            get { return combatActive; }
            set { combatActive = value; }
        }
    }
}