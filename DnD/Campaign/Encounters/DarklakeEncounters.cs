using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.OOTA
{
    class DarklakeTerrainEncounters
    {
        public List<string> Encounter;
        public List<string> Description;

        public DarklakeTerrainEncounters()
        {
            Encounter = new List<string>();

            Encounter.Add("Collision");
            Encounter.Add("Falls or Lock");
            Encounter.Add("Island");
            Encounter.Add("Low Ceiling");
            Encounter.Add("Rock Fall");
            Encounter.Add("Rough Current");
            Encounter.Add("Run Aground");
            Encounter.Add("Stone Teeth");
            Encounter.Add("Tight Passage");
            Encounter.Add("Whirlpool");

            Description = new List<string>();

            Description.Add("This terrain encounter occurs only if one or more party members are traveling by raft or boat, and there’s a strong current. Have everyone aboard the vessel make a DC 13 group Dexterity check to avoid hitting a wall or other large obstacle directly ahead. If the group check succeeds, the collision is avoided. Otherwise, the vessel takes 2d10 bludgeoning damage from the collision, and everyone aboard must succeed on a DC 10 Strength or Dexterity saving throw to avoid falling overboard.");
            Description.Add("Any character with a passive Wisdom (Perception) score of 12 or better can hear the roar of a waterfall ahead. A successful DC 14 group Strength (Athletics) check is necessary to steer or swim away from the falls. Otherwise, the characters go over, falling 1d6 × 10 feet into a pool or river 1d6 × 5 feet deep. A creature swept over the falls must succeed on a DC 11 Dexterity saving throw or take 1d6 bludgeoning damage per 10 feet fallen. A successful save indicates that the creature avoids a hard landing in the water below. There is a 50 percent chance that any waterfall area contains a duergar-built lock designed to traverse it, in which case there is no risk of going over the falls. It takes a successful DC 11 Intelligence (Investigation) check to figure out how to operate the lock. Once a lock is opened, it takes 1 hour for the water level to lower so the party can proceed.");
            Description.Add("A small island rises from the water ahead. An island with no hostile creatures makes a good place for the party to take a long rest. There is a 50 percent chance that the island has one or more types of fungi growing atop it (see “Fungi of the Underdark” in chapter 2). Otherwise, the island is barren rock.");
            Description.Add("The clearance of the cave or passage lowers suddenly to 3 feet above the water’s surface. Each Medium character must succeed on a DC 10 Dexterity saving throw or take 1d4 bludgeoning damage from hitting the ceiling before the passage ends.");
            Description.Add("Loose rocks fall from the ceiling above. Each character must succeed on a DC 12 Dexterity saving throw or be hit by a chunk of falling stone for 2d6 bludgeoning damage. If the characters are traveling in a boat or raft, their vessel takes 2d6 bludgeoning damage for each successful save; in other words, each rock that misses a character hits the boat or raft instead. Roll the damage for each rock striking a vessel separately to see if it overcomes the vessel’s damage threshold.");
            Description.Add("The waters here are especially turbulent. If the characters are traveling by boat or raft, the crew must succeed on a DC 13 group Dexterity check to maintain control. If the group check fails, the vessel takes 2d6 bludgeoning damage, and each occupant must succeed on a DC 10 Strength or Dexterity saving throw to avoid falling overboard.");
            Description.Add("This terrain encounter occurs only if one or more party members are traveling by raft or boat. The vessel hits a shallow area or sandbar and runs aground. The characters can push the vessel back into the water with a successful DC 10 group Strength (Athletics) check. While characters are pushing their boat free, there is a 50 percent chance that one or more creatures attack them; in this event, roll on the Darklake Creature Encounters table to determine what attacks.");
            Description.Add("This terrain encounter occurs only if one or more party members are traveling by raft or boat, and there’s a strong current. Stalagmites jutting up from the bottom of a tunnel are hidden just below the waterline. Spotters must succeed on a DC 13 Wisdom (Perception) check to notice the “stone teeth,” allowing the vessel’s crew to attempt a DC 12 group Dexterity check to navigate through them. If the group check succeeds, the vessel passes through unscathed. Failure to notice or navigate through the stone teeth deals 6d6 piercing damage to the boat or raft.");
            Description.Add("The adventurers encounter an especially tight passage, requiring a successful DC 12 group Dexterity check to navigate a boat or raft through it. If the group check succeeds, the boat slips through. Otherwise, the boat gets stuck, requiring a successful DC 14 group Strength (Athletics) check to push it free. While characters are pushing their boat free, there is a 50 percent chance that one or more creatures attack them; in this event, roll on the Darklake Creature Encounters table to determine what attacks.");
            Description.Add("An underwater crevasse or drain creates a small vortex in this area, much like the whirlpool effect of the control water spell (save DC 14).");
        }
    }

    class DarklakeCreatureEncounters
    {
        public List<string> Encounter;
        public List<string> Description;

        public DarklakeCreatureEncounters()
        {
            Encounter = new List<string>();

            Encounter.Add("1 Aquatic Troll");
            Encounter.Add("2d4 darkmantles");
            Encounter.Add("1d4 + 2 duergar in a keelboat");
            Encounter.Add("1 green hag");
            Encounter.Add("1 grell");
            Encounter.Add("1d6 +2 ixitxachitl");
            Encounter.Add("1d6 +2 ixitxachitl");
            Encounter.Add("1d4 kuo-toa in a keelboat");
            Encounter.Add("1d4 merrow");
            Encounter.Add("3d6 stirges");
            Encounter.Add("1 swarm of quippers");
            Encounter.Add("1 water weird");

            Description = new List<string>();

            Description.Add("An aquatic troll swims up from the depths. It has the abilities of a normal troll, but can also breathe water and has a swimming speed of 30 feet.");
            Description.Add("These creatures cling to the ceiling as the adventurers approach, cloaking themselves in darkness as they unfurl and attack. A creature in a boat or on a raft that tries and fails to detach a darkmantle from itself or another creature must succeed on a DC 10 Dexterity saving throw or fall out of the vessel and into the water.");
            Description.Add("A keelboat crewed by duergar is traversing the Darklake on business. The gray dwarves parley with the adventurers—or attack them if the opportunity looks ripe to capture them and sell them as slaves in Gracklstugh. If the duergar surprise all the characters, they turn invisible, making it appear that their boat is abandoned so as to lure the adventurers on board before they attack. Roll a d20 and consult the Duergar Keelboat Cargo table to determine what, if anything, the duergar are transporting in their keelboat. Duergar Keelboat Cargo d20 Cargo 1–10 None 11–13 1d20 × 100 pounds of unrefined iron ore 14–16 1d4 zurkhwood crates filled with mining tools 17–19 2d4 zurkhwood casks of harvested fungi (see “Fungi of the Underdark” in chapter 2) 20 A locked iron chest containing 3d6 × 100 gp and a random magic item (roll once on Magic Item Table B in chapter 7 of the Dungeon Master’s Guide).");
            Description.Add("Nanny Plunk is a green hag who likes to taunt and lead travelers astray. She might instead bargain with the characters with her knowledge of the Darklake, especially if her life or freedom is at stake. If this encounter occurs again, it might be with Nanny or one of her sisters, Maven Delve or Dame Spiderwort.");
            Description.Add("A grell descends from the cavern ceiling, attempting to grab and paralyze one party member, then fly off with its victim.");
            Description.Add("These creatures attack any party members in the water. Otherwise, they follow the party and wait for an opportunity to strike. If denied a meal for too long, they begin to gnaw on the hull of a boat or the underside of a raft, hoping to sink it (this tactic is ineffective against craft with a high damage threshold).");
            Description.Add("These creatures attack any party members in the water. Otherwise, they follow the party and wait for an opportunity to strike. If denied a meal for too long, they begin to gnaw on the hull of a boat or the underside of a raft, hoping to sink it (this tactic is ineffective against craft with a high damage threshold).");
            Description.Add("These kuo-toa pole a keelboat toward Sloobludop (or away from the town if it has been attacked; see the end of this chapter). If the characters have not been to Sloobludop, the kuo-toa might try to capture them and bring them there. See “The Day’s Catch” for details. Roll a d20 and consult the Kuo-toa Keelboat Cargo table to determine what, if anything, the duergar are transporting in their keelboat. Kuo-toa Keelboat Cargo d20 Cargo 1–15 None 16–17 1d4 nets; each net has a 50 percent chance of containing 3d6 dead, edible quippers 18–19 1d4 nets; each net has a 50 percent chance of containing 1d4 living stirges 20 1d4 pieces of broken, barnacle-encrusted statuary, each worth 50 gp; each weighing 1d4 × 5 pounds; and each depicting a weird alien creature, a longforgotten god, or fragment thereof.");
            Description.Add("These worshipers of Demogorgon have been driven into a frenzy by his arrival in the Underdark. They immediately attack, trying to capsize or wreck boats as they utter the war cry, “Blood and salt for the Prince of Demons!” in Abyssal. A merrow can use its action to capsize a boat or raft within 5 feet of it. Anyone in the boat can thwart the merrow by using a reaction to make a Strength check contested by the merrow’s Strength check. If the merrow wins the contest, the vessel capsizes.");
            Description.Add("These stirges cling to the ceiling like bats. If the party is aware of the stirges, the characters can make a DC 13 group Dexterity (Stealth) check to slip past the stirges without disturbing them. If the group check succeeds, the stirges ignore the party. Otherwise, the stirges descend and attack the nearest party members.These stirges cling to the ceiling like bats. If the party is aware of the stirges, the characters can make a DC 13 group Dexterity (Stealth) check to slip past the stirges without disturbing them. If the group check succeeds, the stirges ignore the party. Otherwise, the stirges descend and attack the nearest party members.");
            Description.Add("A swarm of quippers keeps pace with the characters, attacking anyone in the water. If an hour passes and no meal has presented itself, the quippers stop following the party.");
            Description.Add("Bound to some long-lost site beneath the surface of the water, this neutral evil elemental rises to attack when the characters pass by. Roll a d6 and consult the Weird Discoveries table to determine what the water weird is guarding. Weird Discoveries d6 Discovery 1–2 Sunken altar dedicated to a forgotten deity 3–4 Sunken statue with 500 gp black pearls for eyes; a thief who removes one or both gems becomes the target of a contagion spell (save DC 14). 5–6 Sunken, sealed sarcophagus containing a mummy and 1d4 art objects (roll on the 250 gp Art Objects table in chapter 7 of the Dungeon Master’s Guide)");
        }
    }

    class DarkLakeEncounters
    {
        public DarklakeTerrainEncounters TerrainEncounter;
        public DarklakeCreatureEncounters CreatureEncounter;

        public DarkLakeEncounters()
        {
            TerrainEncounter = new DarklakeTerrainEncounters();
            CreatureEncounter = new DarklakeCreatureEncounters();
        }
    }

}
