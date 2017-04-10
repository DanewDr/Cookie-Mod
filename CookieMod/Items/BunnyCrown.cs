using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
	
    public class BunnyCrown : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bunny Crown";
            item.width = 20;
            item.height = 20;
            item.toolTip = "Summons the Bunny King";
            item.value = 1300;
            item.rare = 1;
            item.maxStack = 20;
			      item.useStyle = 4;
			      item.useAnimation = 30;
            item.useTime = 30;
            item.consumable = true;
        }
		
		
 		public override bool UseItem(Player player)
		{
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
			Main.NewText("<Bunny King> Finally, I shall have my revenge!" (byte)146, (byte)101, (byte)15, false);
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("BunnyKing"));
			return true;
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "BunnyFur", 12);
			      recipe.AddIngredient(ItemID.Bunny, 2);
			      recipe.AddIngredient(ItemID.GoldenBunny, 2);
            recipe.AddIngredient(ItemID.GoldCrown);
			      recipe.AddTile(TileID.DemonAlter);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
