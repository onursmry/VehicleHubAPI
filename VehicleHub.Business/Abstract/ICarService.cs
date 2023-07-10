using VehicleHub.Core.Utilities.Results;
using VehicleHub.Entities.Concrete;

namespace VehicleHub.Business.Abstract;

public interface ICarService
{
    IDataResult<List<Car>> GetAll();
    IDataResult<List<Car>> GetByColor(string color);
    IDataResult<Car> GetById(Guid id);
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Guid id);
    IResult ToggleHeadlights(Guid id);
}