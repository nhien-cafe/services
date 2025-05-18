using Volo.Abp.Settings;

namespace AbpSolution.Settings;

public class AbpSolutionSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpSolutionSettings.MySetting1));
    }
}
