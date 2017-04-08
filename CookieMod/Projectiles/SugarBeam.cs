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
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.DiamondBolt);
			projectile.name = "Sugar Beam";
			aiType = ProjectileID.DiamondBolt;
		}


        }
 }