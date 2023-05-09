using BTD_Mod_Helper;
using Kenobi;
using MelonLoader;

[assembly: MelonInfo(typeof(Kenobi.Kenobi), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Kenobi
{
   public class Kenobi : BloonsTD6Mod
   {
       public override void OnInitialize()
       { 
           ModHelper.Msg<Kenobi>("This Mod Has A Lot Of Custom Files So Be Patient If It Takes A Second To Load...");
           ModHelper.Msg<Kenobi>("Kenobi Is Gaining The High Ground");
       }
   } 
}
