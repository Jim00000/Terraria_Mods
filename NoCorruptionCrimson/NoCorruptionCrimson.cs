using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.WorldBuilding;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace NoCorruptionCrimson
{
	public class NoCorruptionCrimson : ModSystem
	{
		public override void Load()
        {
            Mod.Logger.InfoFormat("{0} is ready", this.Name);
        }

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            foreach(GenPass pass in tasks)
            {
                Mod.Logger.InfoFormat("{0}", pass.Name);
            }
            tasks.RemoveAll(pass => pass.Name == "Corruption" || pass.Name == "Crimson");
        }
	}
}