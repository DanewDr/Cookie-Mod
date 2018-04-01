using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items
{
	public class CookBook : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault(“Cook Book”);
			Tooltip.SetDefault(“7% increased culinary damage”);

		public override void SetDefaults()
		{
			item.rare = 2;
			item.accessory = true;
			item.value = 100;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			CookDamagePlayer modPlayer = CookDamagePlayer.ModPlayer(player);
			modPlayer.CookDamage += 0.07f;
		}
	}
}
