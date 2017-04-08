using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class DanewsPumpkinPie : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Danew's Pumpkin Pie";
            item.UseSound = SoundID.Item3;                 //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 25;
            item.toolTip = "The pumpkin pie of Danew Dr";
            item.value = 100;                
            item.rare = 1;
            item.buffType = BuffID.WellFed;    //this is where you put your Buff
			item.buffTime = 200000;
			item.buffType = BuffID.Sunflower;
			item.buffTime = 200000;
			item.buffType = BuffID.Slimed;
            item.buffTime = 200000;    //this is the buff duration        20000 = 6 min
            return;
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PumpkinPie, 1);
			recipe.AddIngredient(null, "LivingFlower", 1);
			recipe.AddIngredient(null, "SpecialPumpkinPie", 1);			
			recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
		}
    }
}