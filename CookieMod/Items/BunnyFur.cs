using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items
{
    public class BunnyFur : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Bunny Fur";
            item.width = 20;
            item.height = 20;
            item.toolTip = "Why you kill bunny?";
            item.value = 10;
            item.rare = 1;
            item.maxStack = 999
       }
    }
}
