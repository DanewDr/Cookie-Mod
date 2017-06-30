using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class ChocolateCyclone : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chocolate Cyclone");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.MiniSharkron);
			aiType = ProjectileID.MiniSharkron;
		}


        }
 }
