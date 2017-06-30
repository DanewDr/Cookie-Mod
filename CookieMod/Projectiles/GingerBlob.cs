using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{

    public class GingerBlob : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ginger Blob");     //The English name of the projectile
		}
        public override void SetDefaults()
        {
            projectile.width = 20;       //projectile width
            projectile.height = 28;  //projectile height
			projectile.aiStyle = 16;
            projectile.friendly = true;      //make that the projectile will not damage you
            projectile.penetrate = 2;      //how many npc will penetrate
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;   
        }
    }
}
