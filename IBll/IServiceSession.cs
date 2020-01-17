namespace IBll
{
    public interface IServiceSession
    {
        IUserInfoService UserInfoService { get; }

        IUserPrivilegeInfoService UserPrivilegeInfoService { get; }

        IProjectInfoService ProjectInfoService { get; }

        ISupplyInfoService SupplyInfoService { get; }

        ICategoryInfoService CategoryInfoService { get; }

        ICargoInfoService CargoInfoService { get; }

        ICargoLogInfoService CargoLogInfoService { get; }

        ISupplyCategoryInfoService SupplyCategoryInfoService { get; }
    }
}