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
            item.name = "Dough";
            item.width = 20;
            item.height = 20;
            item.toolTip = "I wouldn't eat it right now.";
            item.value = 100;
            item.rare = 1;
            item.maxStack = 999;
        }
    }
}
