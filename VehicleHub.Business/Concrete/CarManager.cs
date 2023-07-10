using System.Globalization;
using VehicleHub.Business.Abstract;
using VehicleHub.Business.Constants;
using VehicleHub.Core.Utilities.Results;
using VehicleHub.DataAccess.Abstract;
using VehicleHub.Entities.Concrete;

namespace VehicleHub.Business.Concrete;

public class CarManager : ICarService
{
    private readonly ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public IDataResult<List<Car>> GetAll()
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
    }

    public IDataResult<List<Car>> GetByColor(string color)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Color.ToLower() == color.ToLower()), Messages.CarsListedColor);
    }

    public IDataResult<Car> GetById(Guid id)
    {
        return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id), Messages.CarListed);
    }

    public IResult Add(Car car)
    {
        _carDal.Add(car);
        return new SuccessResult(Messages.CarAdded);
    }

    public IResult Update(Car car)
    {
        _carDal.Update(car);
        return new SuccessResult(Messages.CarUpdated);
    }

    public IResult Delete(Guid id)
    {
        _carDal.Delete(new Car { Id = id });
        return new SuccessResult(Messages.CarDeleted);
    }

    public IResult ToggleHeadlights(Guid id)
    {
        var car = _carDal.Get(c => c.Id == id);
        car.Headlights = !car.Headlights;
        _carDal.Update(car);

        if (car.Headlights)
        {
            return new SuccessResult(Messages.CarHeadlightsOn);
        }

        return new SuccessResult(Messages.CarHeadlightsOff);
    }
}