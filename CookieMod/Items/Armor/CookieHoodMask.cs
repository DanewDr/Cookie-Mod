using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace CookieMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CookieHoodMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cookie Mask");
			Tooltip.SetDefault("#putyourhelmetonhappy\n(Magic)");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 2500;
			item.rare = 2;
			item.defense = 4;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CookieBreastplate") && legs.type == mod.ItemType("CookieLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Incresead Magic Damge";
			player.magicDamage *= 1.9f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Cookie", 25);
			recipe.AddTile(null, "CookieWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
