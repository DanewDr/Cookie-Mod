using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Items     //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class GingerShield : ModItem
    {
        public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
        {
            equips.Add(EquipType.Shield);  //this auotoload the shield texture sheet on player
            return true;
        }
 
        public override void SetDefaults()
        {
            item.name = "Ginger Shield";      //the name displayed when hovering over the Weapon ingame.
            item.width = 24;   //The size in width of the sprite in pixels.
            item.height = 28;    //The size in height of the sprite in pixels.
            item.toolTip = "Grants immunity to knockback.";
	    item.toolTip2 = "8% melee damage increase";	//The description of the Weapon shown when hovering over the item ingame.
            item.value = Item.buyPrice(0, 2, 0, 0); //  How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 2 gold)
            item.rare = 4;          //The color the title of your Weapon when hovering over it ingame        
            item.accessory = true;  //this make the item an accessory, so you can equip it
            item.defense = 2;   //this sets the item defense given when equipped
 
        }
        public override void UpdateAccessory(Player player, bool hideVisual)  //this is so when the item is equipped will give this stats to the player
        {
            player.noKnockback = true;   //so the player is immune to knockback
	    player.meleeDamage += .08f;
	    player.meleeSpeed += .04f;
        }
 
 
        public override void AddRecipes()
        {                                        //this is how to craft this item
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CobaltShield, 1);      //this is how to add an ingredient from Terraria,  so for crafting this item you need 1 Cobalt Shield      
            recipe.AddIngredient(null, "GingerCookie", 4);       //and 4 lifecristals
            recipe.AddTile(TileID.Anvils);  //this is where craft the item ,WorkBenches = all WorkBenches    Anvils = all anvils , MythrilAnvil = Mythril Anvil and Orichalcum Anvil, Furnaces = all furnaces , DemonAltar = Demon Altar and Crimson Altar , TinkerersWorkbench = Tinkerer's Workbench
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
 
    }
}
