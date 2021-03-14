using System;
using System.Collections.Generic;

using UnityEngine.UI;   // Handles Image Type

using BreakInfinity;
using Effects;
using AbilityEnumTables;

namespace Abilities
{
    public readonly struct abilityInfo
    {
        public Image icon { get; }
        public AbilityType type { get; }

        public int id { get; }
        public string name { get; }
        public string desc { get; }
        public bool toSelf { get; }

        public abilityInfo(Image ico, AbilityType t, int aID, string n, string d, bool self)
        {
            icon = ico;
            type = t;

            id = aID;
            name = n;
            desc = d;
            toSelf = self;
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

        }

        private void defineAbilities(out Dictionary<int, abilityInfo> aIL, out Dictionary<int, Func<BigDouble>> aL,
                                     out Dictionary<int, Func<List<int>>> aEL)
        {
            // Initialize a temporary string list and all dictionaries.
            List<string> aDesc = new List<string>();
            aIL = new Dictionary<int, abilityInfo>();
            aL = new Dictionary<int, Func<BigDouble>>();
            aEL = new Dictionary<int, Func<List<int>>>();

            // #0000: Throw Rock (Active)
            // Effect: Deals 2 damage to a target.
            aDesc.Add("You lug a pebble on the ground at the enemy.");

            Func<BigDouble> ability0 = delegate ()
            {
                return 2;
            };

            aIL.Add(0, new abilityInfo(null, AbilityType.Active, 0, "Throw Rock", aDesc[0], false));
            aL.Add(0, ability0);

            // #0001: Get Hype (Buff)
            // Effect: Heals user for 1 HP and applies effect(s) 0 to user.
            aDesc.Add("You pump yourself up for this whole adventuring stuff.");

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

            aIL.Add(1, new abilityInfo(null, AbilityType.Buff, 1, "Get Hype", aDesc[1], true));
            aL.Add(1, ability1);
            aEL.Add(1, aEff1);

            // #0002: Crack Your Back (Healing)
            // Effect: Heals the user for 5 HP.
            aDesc.Add("You crack your back which apperently makes you feel a bit better.");

            Func<BigDouble> ability2 = delegate ()
            {
                return 5;
            };

            aIL.Add(2, new abilityInfo(null, AbilityType.Healing, 2, "Crack Your Back", aDesc[2], true));
            aL.Add(2, ability2);

            // #0003: Armor Crash (Debuff)
            // Effect: Deals 3 damage and inflicts effect(s) 2 to a target.
            aDesc.Add("You hit the enemy so hard their armor (metaphorically) turns to jelly!");

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

            aIL.Add(3, new abilityInfo(null, AbilityType.Debuff, 3, "Armor Crash", aDesc[3], false));
            aL.Add(3, ability3);
            aEL.Add(3, aEff3);
        }
    }
}