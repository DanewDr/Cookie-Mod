using System;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using CookieMod.Items;

namespace CookieMod
{
	
    public class CookieMod : Mod
    {
        public override void PostSetupContent()
        {
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if(bossChecklist != null)
            {

                bossChecklist.Call("AddBossWithInfo", "Corrupt/Blood Cookie", 3.5f, (Func<bool>)(() => CookieModWorld.downedCookieBoss), "Use a [i:" + ItemType("CursedCookie") + "] or a [i:" + ItemType("BloodyCookie") + "] at night");
            }
        }		
        public CookieMod()
        {

            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true,
				AutoloadBackgrounds = true
            };
        }
	public override void AddRecipeGroups()
        {
		RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Corrupted Bar", new int[] //Souls is the name of the RecipeGroup
		{
			ItemID.DemoniteBar,
			ItemID.CrimtaneBar,
		});
            RecipeGroup.RegisterGroup("CorruptBar", group);
        }
    }
}
