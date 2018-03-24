using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class VanillaChanges : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BottledWater)
			{
				item.damage = 5;
				item.shoot = mod.ProjectileType ("Water");
				item.ammo = mod.ItemType("BloodySoup");
			}
		}
	}
}