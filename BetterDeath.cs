using Terraria.ModLoader;

namespace BetterDeath
{
    public class BetterDeath : Mod
    {
        public override void Load()
        {
            Edits.Load();
            base.Load();
        }
    }
}