using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items.Weapons      
{
    public class ChocolateBattleaxe : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Chocolate Battle-Axe";    //the name displayed when hovering over the Weapon ingame.
            item.damage = 35;    //The damage stat for the Weapon.
            item.melee = true;     //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.width = 114;    //The size of the width of the hitbox in pixels.
            item.height = 78;    //The size of the height of the hitbox in pixels.
            item.useTime = 44;   //How fast the Weapon is used.
            item.useAnimation = 10;     //How long the Weapon is used for.
            item.channel = true;
            item.useStyle = 100;    //The way your Weapon will be used, 1 is the regular sword swing for example
            item.knockBack = 8f;    //The knockback stat of your Weapon.
            item.value = Item.buyPrice(0, 10, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 3;   //The color the title of your Weapon when hovering over it ingame                    
            item.shoot = mod.ProjectileType("ChocolateBattleaxeProjectile");  //This defines what type of projectile this weapon will shoot  
            item.noUseGraphic = true; // this defines if it does not use graphic
        }
 
        public override bool UseItemFrame(Player player)     //this defines what frame the player use when this weapon is used
        {
            player.bodyFrame.Y = 3 * player.bodyFrame.Height;
            return true;
        }
    }
}
