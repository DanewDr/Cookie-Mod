using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Placeable
{
    public class MilkTank : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Milk Dispensor";
            item.width = 28;
            item.height = 20;
            item.maxStack = 99;
            AddTooltip("Don't ask where the milk comes from.");
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