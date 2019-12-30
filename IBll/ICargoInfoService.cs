using Model;
using Model.ReturnMessageModel;

namespace IBll
{
    public interface ICargoInfoService : IBaseService<CargoInfo>
    {
        ReturnMessageModel CargoIn(int id, decimal count);

        ReturnMessageModel CargoOut(int id, decimal count);
    }
}