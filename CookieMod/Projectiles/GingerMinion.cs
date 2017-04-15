using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class GingerMinion : ModProjectile
    {
    	
        public override void SetDefaults()
        {
            projectile.name = "Ginger Minion";
            projectile.width = 24;
            projectile.height = 24;
            projectile.netImportant = true;
            projectile.friendly = true;
            projectile.minionSlots = 1;
            projectile.alpha = 75;
            projectile.aiStyle = 26;
            projectile.timeLeft = 18000;
            Main.projFrames[projectile.type] = 2;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            projectile.penetrate = -1;
            projectile.timeLeft *= 5;
            projectile.minion = true;
            aiType = 613;
            projectile.tileCollide = false;
        }
        
        public override void TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
        	fallThrough = false;
        }

        public override void AI()
        {
        	bool flag64 = projectile.type == mod.ProjectileType("GingerMinion");
			Player player = Main.player[projectile.owner];
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>(mod);
			if (flag64)
			{
				if (player.dead)
				{
					modPlayer.GingerMinion = false;
				}
				if (modPlayer.GingerMinion)
				{
					projectile.timeLeft = 2;
				}
			}
		}
        
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            if (projectile.penetrate == 0)
            {
                projectile.Kill();
            }
            return false;
        }
    }
}
