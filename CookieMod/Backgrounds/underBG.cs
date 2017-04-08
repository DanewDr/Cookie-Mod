using Terraria;
using Terraria.ModLoader;
 
namespace CookieMod.Backgrounds
{
    public class underBG : ModUgBgStyle
    {
        public override bool ChooseBgStyle()
        {
			return Main.LocalPlayer.GetModPlayer<MyPlayer>(mod).ZoneCookieBiome;
        }
 
        public override void FillTextureArray(int[] textureSlots)
        {
            textureSlots[0] = mod.GetBackgroundSlot("Backgrounds/UndergroundbgTop");          //this is the underground bg top . this bg will show where the underground bg starts
            textureSlots[1] = mod.GetBackgroundSlot("Backgrounds/Undergroundbg");          // this is the underground bg
            textureSlots[2] = mod.GetBackgroundSlot("Backgrounds/Cavernbg2Top");           //this is the cavern bg top. this bg will show in the middle of underground and cavern bg
            textureSlots[3] = mod.GetBackgroundSlot("Backgrounds/Cavernbg");          //this is the cavern bg
        }
    }
}