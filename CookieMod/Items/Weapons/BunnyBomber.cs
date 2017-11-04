using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Items.Weapons
{
    public class BunnyBomber : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny Bomber");
			Tooltip.SetDefault("Somehow the bullets aren't tearing it apart from the inside");
		}
        public override void SetDefaults()
        {
            item.damage = 12;  //gun damage
            item.ranged = true;   //its a gun so set this to true
            item.width = 40;     //gun image width
            item.height = 16;   //gun image  height
            item.useTime = 10;  //how fast 
            item.useAnimation = 20;
            item.useStyle = 5;    //
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 2;
            item.value = 1200;
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 13f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override void AddRecipes()  //How to craft this gun
        {
           ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "BunnyFur", 12);   //you need 1 DirtBlock
	    recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}