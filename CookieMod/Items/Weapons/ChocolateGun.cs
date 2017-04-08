using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class ChocolateGun : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Chocolate Gun";  //Gun name  
            item.damage = 20;  //gun damage
            item.ranged = true;   //its a gun so set this to true
            item.width = 38;     //gun image width
            item.height = 18;   //gun image  height
            item.useTime = 5;  //how fast 
            item.useAnimation = 20;
            item.useStyle = 5;    //
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 2;
            item.value = 1200;
            item.rare = 2;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 13f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()  //How to craft this gun
        {
           ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "ChocolateCookie", 12);   //you need 1 DirtBlock
            recipe.AddTile(null, "CookieWorkbench");   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}