using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDal
{
    public interface IDbSession
    {
        IUserInfoDal UserInfoDal { get; }

        IUserPrivilegeInfoDal UserPrivilegeInfoDal { get; }

        IProjectInfoDal ProjectInfoDal { get; }

        ISupplyInfoDal SupplyInfoDal { get; }

        ICategoryInfoDal CategoryInfoDal { get; }

        ICargoInfoDal CargoInfoDal { get; }

        ICargoLogInfoDal CargoLogInfoDal { get; }

        IOrderInfoDal OrderInfoDal { get; }

        ISupplyCategoryInfoDal SupplyCategoryInfoDal { get; }

        int SaveChanges();

    }
}
