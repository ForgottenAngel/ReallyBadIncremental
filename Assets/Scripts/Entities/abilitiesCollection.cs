using System;
using System.Collections.Generic;

using UnityEngine.UI;   // Handles Image Type

using BreakInfinity;
using Effects;
using AbilityEnumTables;

namespace Abilities
{
    public readonly struct abilityScaling
    {
        public float strScale { get; }
        public float intScale { get; }
        public float conScale { get; }
        public float wilScale { get; }

        public float pAtkScale { get; }
        public float mAtkScale { get; }

        public abilityScaling(float strS, float intS, float conS, float wilS, 
                              float pAtkS, float mAtkS)
        {
            strScale = strS;
            intScale = intS;
            conScale = conS;
            wilScale = wilS;

            pAtkScale = pAtkS;
            mAtkScale = mAtkS;
        }
    }

    public readonly struct abilityInfo
    {
        public Image icon { get; }
        public AbilityType type { get; }

        public int id { get; }
        public string name { get; }
        public string desc { get; }
        public bool toSelf { get; }

        public abilityScaling scaling {get;}

        public abilityInfo(Image ico, AbilityType t, int aID, string n, string d, bool self,
                           abilityScaling scale)
        {
            icon = ico;
            type = t;

            id = aID;
            name = n;
            desc = d;
            toSelf = self;

            scaling = scale;
        }
    }
    public class abilitiesCollection
    {
        // Lookup Tables for Active Abilities
        public readonly Dictionary<int, abilityInfo> abilityInfoList;
        public readonly Dictionary<int, Func<BigDouble>> abilityList;
        public readonly Dictionary<int, Func<List<int>>> abilEffectList;

        public abilitiesCollection()
        {
            defineAbilities(out abilityInfoList, out abilityList, out abilEffectList);
        }

        private void defineAbilities(out Dictionary<int, abilityInfo> aIL, out Dictionary<int, Func<BigDouble>> aL,
                                     out Dictionary<int, Func<List<int>>> aEL)
        {
            // Initialize a temporary string list and all dictionaries.
            List<string> aDesc = new List<string>();
            List<abilityScaling> aScal = new List<abilityScaling>();

            aIL = new Dictionary<int, abilityInfo>();
            aL = new Dictionary<int, Func<BigDouble>>();
            aEL = new Dictionary<int, Func<List<int>>>();

            // #0000: Throw Rock (Active)
            // Effect: Deals 2 damage to a target.
            // Scaling >> 1x STR
            aDesc.Add("You lug a pebble on the ground at the enemy.");
            aScal.Add(new abilityScaling(1f, 0f, 0f, 0f, 0f, 0f));

            Func<BigDouble> ability0 = delegate ()
            {
                return 2;
            };

            aIL.Add(0, new abilityInfo(null, AbilityType.Active, 0, "Throw Rock", aDesc[0], false, aScal[0]));
            aL.Add(0, ability0);

            // #0001: Get Hype (Buff)
            // Effect: Heals user for 1 HP and applies effect(s) 0 to user.
            // Scaling >> 3x WIL
            aDesc.Add("You pump yourself up for this whole adventuring stuff.");
            aScal.Add(new abilityScaling(0f, 0f, 0f, 3f, 0f, 0f));

            Func<BigDouble> ability1 = delegate ()
            {
                return 1;
            };

            Func<List<int>> aEff1 = delegate ()
            {
                List<int> effVals = new List<int>
                {
                    0
                };
                return effVals;
            };

            aIL.Add(1, new abilityInfo(null, AbilityType.Buff, 1, "Get Hype", aDesc[1], true, aScal[1]));
            aL.Add(1, ability1);
            aEL.Add(1, aEff1);

            // #0002: Crack Your Back (Healing)
            // Effect: Heals the user for 5 HP.
            // Scaling >> 1.05x STR
            aDesc.Add("You crack your back which apperently makes you feel a bit better.");
            aScal.Add(new abilityScaling(1.05f, 0f, 0f, 0f, 0f, 0f));

            Func<BigDouble> ability2 = delegate ()
            {
                return 5;
            };

            aIL.Add(2, new abilityInfo(null, AbilityType.Healing, 2, "Crack Your Back", aDesc[2], true, aScal[2]));
            aL.Add(2, ability2);

            // #0003: Armor Crash (Debuff)
            // Effect: Deals 3 damage and inflicts effect(s) 2 to a target.
            // Scaling >> 2x STR | 0.5x P.Atk
            aDesc.Add("You hit the enemy so hard their armor (metaphorically) turns to jelly!");
            aScal.Add(new abilityScaling(2f, 0f, 0f, 0f, 0.5f, 0f));

            Func<BigDouble> ability3 = delegate ()
            {
                return 3;
            };

            Func<List<int>> aEff3 = delegate ()
            {
                List<int> effVals = new List<int>
                {
                    2
                };
                return effVals;
            };

            aIL.Add(3, new abilityInfo(null, AbilityType.Debuff, 3, "Armor Crash", aDesc[3], false, aScal[3]));
            aL.Add(3, ability3);
            aEL.Add(3, aEff3);
        }
    }
}