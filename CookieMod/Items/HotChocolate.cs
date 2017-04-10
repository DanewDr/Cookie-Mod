using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
 
namespace CookieMod.Items
{
    public class HotChocolate : ModItem
    {
        public override void SetDefaults()
        {
        item.name = "Hot Chocolate";
        item.UseSound = SoundID.Item3;
        item.useStyle = 2;
        item.useTurn = true;
        item.useAnimation = 17;
        item.useTime = 17;
        item.maxStack = 99;
        item.width = 10;
        item.height = 10;
        item.buffType = 25;
        item.buffTime = 7200;
	item.consumable = true;
        item.value = 100;
        item.holdStyle = 1;
        item.ammo = 353;
        item.notAmmo = true;
	item.shoot = mod.ProjectileType ("HotChocolate");
        }
	public override void HoldStyle(Player player)
	{
	  player.itemLocation.X = player.Center.X + (float) (8 * player.direction);
          player.itemLocation.Y = player.MountedCenter.Y + 11f;
	}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Mug, 3);
	    recipe.AddIngredient(null, "Milk");
	    recipe.AddIngredient(null, "MoltenChocolate");
	    recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}
