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
		public override void AI()
		{
			projectile.velocity.Y += projectile.ai[0];
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("GingerCrumbs"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}			
        }
    }