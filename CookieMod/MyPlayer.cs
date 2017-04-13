using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace CookieMod
{
    public class MyPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool CookieMinion = false;
	public bool ChocMin;
	public bool HoneyImp = false;
        public static bool hasProjectile;
	public bool ZoneCookieBiome = false;
        public override void ResetEffects()
        {
            CookieMinion = false;
	    ChocMin = false;
	    HoneyImp = false;
        }
		public override void UpdateBiomes()
        {
            ZoneCookieBiome = (CookieModWorld.customBiome > 50);    
        }
    }
}
