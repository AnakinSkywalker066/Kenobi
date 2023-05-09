
using System.Linq;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.TowerSets;
using Il2CppAssets.Scripts.Utils;


namespace Kenobi;

public class ObiWan : ModTower
{
    public override TowerSet TowerSet =>TowerSet.Military;
    public override string BaseTower => "DartMonkey";
    public override int Cost => 1000;
    public override int TopPathUpgrades => 0;
    public override int MiddlePathUpgrades => 0;
    public override int BottomPathUpgrades => 0;
    public override void ModifyBaseTowerModel(TowerModel towerModel)
    {
        
    }

    public override int GetTowerIndex(System.Collections.Generic.List<TowerDetailsModel> towerSet)
    {
        return towerSet.First(model => model.towerId == TowerType.SniperMonkey).towerIndex;
    }

    public override bool IsValidCrosspath(int[] tiers) =>
        ModHelper.HasMod("UltimateCrosspathing") || base.IsValidCrosspath(tiers);
}