using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class SauteedMushroom : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sauteed Mushroom");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.MiniSharkron);
			aiType = ProjectileID.MiniSharkron;
			projectile.width = 10;
			projectile.height = 12;
		}
        }
 }
