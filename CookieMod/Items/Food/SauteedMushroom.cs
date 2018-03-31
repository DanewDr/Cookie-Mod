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
			Tooltip.SetDefault("<right> to eat!");
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
			item.shoot = mod.ProjectileType ("SauteedMushrooms");
			item.ammo = item.type;
		}
		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
      int health = player.statLife + 25
			if (health > statLifeMax)
      {
        player.statLife == player.statLifeMax;
      }
      else
      {
      player.statLife == health;
      }
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
