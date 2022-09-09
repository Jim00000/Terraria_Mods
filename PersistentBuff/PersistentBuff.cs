using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using System;

namespace PersistentBuff
{
	public class PersistentBuff : GlobalBuff
	{

        public override void Load()
        {
            base.Load();
		}

        public virtual bool IsBuffType(int type)
        {
			switch(type)
            {
				/* Consumables */
				case BuffID.AmmoReservation:
				case BuffID.Archery:
				case BuffID.Builder:
				case BuffID.Crate:
				case BuffID.Dangersense:
				case BuffID.Endurance:
				case BuffID.Fishing:
				case BuffID.Heartreach:
				case BuffID.Hunter:
				case BuffID.Ironskin:
				case BuffID.Lifeforce:
				case BuffID.Lucky:
				case BuffID.MagicPower:
				case BuffID.ManaRegeneration:
				case BuffID.Mining:
				case BuffID.NightOwl:
				case BuffID.ObsidianSkin:
				case BuffID.Rage:
				case BuffID.Regeneration:
				case BuffID.Shine:
				case BuffID.Sonar:
				case BuffID.Spelunker:
				case BuffID.Summoning:
				case BuffID.Swiftness:
				case BuffID.Titan:
				case BuffID.WaterWalking:
				case BuffID.Warmth:
				case BuffID.Wrath:
				/* Activated Furniture */
				case BuffID.AmmoBox:
				case BuffID.Bewitched:
				case BuffID.Clairvoyance:
				case BuffID.Sharpened:
				case BuffID.SugarRush:
					return true;
				default:
					return false;
            }
        }

        public override void Update(int type, Player player, ref int buffIndex)
		{
			if(player.HasBuff(type) && IsBuffType(type))
            {
				player.buffTime[buffIndex] = 60 * 60 * 5 - 1;
			}
		}
	}
}