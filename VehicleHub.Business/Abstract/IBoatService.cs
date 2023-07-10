using VehicleHub.Core.Utilities.Results;
using VehicleHub.Entities.Concrete;

namespace VehicleHub.Business.Abstract;

public interface IBoatService
{
    IDataResult<List<Boat>> GetAll();
    IDataResult<List<Boat>> GetByColor(string color);
    IDataResult<Boat> GetById(Guid id);
    IResult Add(Boat boat);
    IResult Update(Boat boat);
    IResult Delete(Guid id);
}