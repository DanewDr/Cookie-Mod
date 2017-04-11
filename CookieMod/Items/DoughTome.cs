using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace CookieMod.Items
{
  public class DoughTome : ModItem
  {
    public override void SetDefaults()
    {
      item.name = "Spell Book - Pastry Protection";
      item.width = 28;
      item.height = 32;
      item.toolTip = "Covers you in a layer of dough.";
      item.useTime = 40;
      item.useAnimation = 40;
      item.useStyle = 4;
      item.noMelee = true;
      item.rare = 1;
      item.autoReuse = false;
    }
    public override bool CanUseItem(Player player)
    {
      if (player.FindBuffIndex(21) == -1)
      {
        player.AddBuff(BuffID.21), 360);
      }
      return base.CanUseItem(player);
    }
  }
}
