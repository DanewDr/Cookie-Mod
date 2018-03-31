using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Food
{
	public class SauteedMushroom : CookClass
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sauteed Mushroom");
			Tooltip.SetDefault("");
		}
		public override void SafeSetDefaults()
		{
			item.width = 22;
			item.height = 24;
      			item.damage = 4;
      			item.crit = 2;
      			item.UseSound = SoundID.Item2;
			item.maxStack = 30;
			item.rare = 1;
			item.consumable = true;
      			item.value = 400;
			item.shoot = mod.ProjectileType ("SauteedMushroom");
			item.ammo = item.type;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom);
			recipe.SetResult(this);
      recipe.AddTile(TileID.Furnace);
			recipe.AddRecipe();
		}
	}
}
