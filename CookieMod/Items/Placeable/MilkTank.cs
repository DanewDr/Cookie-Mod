using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Placeable
{
    public class MilkTank : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Milk Dispensor");
			Tooltip.SetDefault("Don't ask where the milk comes from");
		}
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 20;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("MilkTank");
        }
 
    }
}
