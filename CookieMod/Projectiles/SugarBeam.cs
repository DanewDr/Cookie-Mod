using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CookieMod.Projectiles
{
    public class SugarBeam : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sugar Beam");     //The English name of the projectile
		}
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.DiamondBolt);
			aiType = ProjectileID.DiamondBolt;
		}


        }
 }
