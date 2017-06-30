using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod.Projectiles.Minions
{
    public class HoneyP : ModProjectile
    {
 		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Honey Stream");     //The English name of the projectile
		}        
        private int[] dusts = {160, 600, 64, 61, 50, 60, 590};
       
        public override void SetDefaults()
        {
            projectile.width = 6;
            projectile.height = 32;
            projectile.aiStyle = 0;
            projectile.alpha = 0;
            projectile.timeLeft = 150;
            projectile.friendly = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = false;
            projectile.magic = true;          
            projectile.penetrate = 1;
        }
        public override void AI()
        {
            if (projectile.localAI[0] == 0f)
            {
                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 20);
                projectile.localAI[0] = 1f;
            }
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 66, 0f, 0f, 100, new Color(224, 179, 88), 1.5f);
            Main.dust[dust].velocity *= 0.1f;
            if (projectile.velocity == Vector2.Zero)
            {
                Main.dust[dust].velocity.Y -= 1f;
                Main.dust[dust].scale = 1.2f;
            }
            else
            {
                Main.dust[dust].velocity += projectile.velocity * 0.2f;
            }
            Main.dust[dust].position.X = projectile.Center.X + 4f + (float)Main.rand.Next(-2, 3);
            Main.dust[dust].position.Y = projectile.Center.Y + (float)Main.rand.Next(-2, 3);
            Main.dust[dust].noGravity = true;
        }
      public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
	     {
			        target.AddBuff(mod.BuffType("Honeyed"), 500);
		    }
    }
}
