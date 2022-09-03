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
				//Reduces the chance of consuming any ammunition by 20%
				case BuffID.AmmoReservation:
				case BuffID.Spelunker:
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
				player.buffTime[buffIndex] = 60 * 60 * 10;
			}
		}
	}
}