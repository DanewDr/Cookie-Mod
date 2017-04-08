using Terraria;
using Terraria.ModLoader;
 
namespace CookieMod.Backgrounds
{
    public class Cookie : ModSurfaceBgStyle
    {
        public override bool ChooseBgStyle()
        {
			return !Main.gameMenu && Main.LocalPlayer.GetModPlayer<MyPlayer>(mod).ZoneCookieBiome;   //ZoneCustomBiome is the bool that u add in MyPlayer so make sure they are the same
        }
 
        // Use this to keep far Backgrounds like the mountains.
        public override void ModifyFarFades(float[] fades, float transitionSpeed)
        {
            for (int i = 0; i < fades.Length; i++)
            {
                if (i == Slot)
                {
                    fades[i] += transitionSpeed;
                    if (fades[i] > 1f)
                    {
                        fades[i] = 1f;
                    }
                }
                else
                {
                    fades[i] -= transitionSpeed;
                    if (fades[i] < 0f)
                    {
                        fades[i] = 0f;
                    }
                }
            }
        }
 
        public override int ChooseFarTexture()
        {
            return mod.GetBackgroundSlot("Backgrounds/sbFar");    //this is the surface biome far bg
        }
 
 
        public override int ChooseMiddleTexture()
        {
            return mod.GetBackgroundSlot("Backgrounds/sbMiddle");      //this is the surface biome middle gackground
        }
 
 
        public override int ChooseCloseTexture(ref float scale, ref double parallax, ref float a, ref float b)
        {
            return mod.GetBackgroundSlot("Backgrounds/sbClose");      //this is the surface biome close gackground
        }
    }
}