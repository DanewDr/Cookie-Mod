using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class DoughBall : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Dough Ball";
            item.width = 20;
            item.height = 20;
            item.toolTip = "Used to craft cookies";
            item.value = 100;
            item.rare = 1;
            item.maxStack = 999;
        }
    }
}