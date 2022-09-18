using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using System;

namespace InfiniteMinions
{
	public class InfiniteMinions : GlobalBuff
	{
		public override void Load()
		{
			base.Load();
		}

		public override void Update(int type, Player player, ref int buffIndex)
		{
			player.maxMinions = 6;
		}
	}
}