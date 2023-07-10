using VehicleHub.Core.Utilities.Results;
using VehicleHub.Entities.Concrete;

namespace VehicleHub.Business.Abstract;

public interface IBusService
{
    IDataResult<List<Bus>> GetAll();
    IDataResult<List<Bus>> GetByColor(string color);
    IDataResult<Bus> GetById(Guid id);
    IResult Add(Bus bus);
    IResult Update(Bus bus);
    IResult Delete(Guid id);
}