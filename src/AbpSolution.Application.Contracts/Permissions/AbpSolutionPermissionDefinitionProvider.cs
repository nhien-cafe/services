using AbpSolution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace AbpSolution.Permissions;

public class AbpSolutionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpSolutionPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(AbpSolutionPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AbpSolutionPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AbpSolutionPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AbpSolutionPermissions.Books.Delete, L("Permission:Books.Delete"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpSolutionPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpSolutionResource>(name);
    }
}
