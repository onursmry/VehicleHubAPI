using VehicleHub.Business.Abstract;
using VehicleHub.Business.Constants;
using VehicleHub.Core.Utilities.Results;
using VehicleHub.DataAccess.Abstract;
using VehicleHub.Entities.Concrete;

namespace VehicleHub.Business.Concrete;

public class BusManager:IBusService
{
    private readonly IBusDal _busDal;

    public BusManager(IBusDal busDal)
    {
        _busDal = busDal;
    }

    public IDataResult<List<Bus>> GetAll()
    {
        return new SuccessDataResult<List<Bus>>(_busDal.GetAll(), Messages.BusesListed);
    }

    public IDataResult<List<Bus>> GetByColor(string color)
    {
        return new SuccessDataResult<List<Bus>>(_busDal.GetAll(b => b.Color.ToLower() == color.ToLower()), Messages.BusesListedColor);
    }

    public IDataResult<Bus> GetById(Guid id)
    {
        return new SuccessDataResult<Bus>(_busDal.Get(b => b.Id == id), Messages.BusListed);
    }

    public IResult Add(Bus bus)
    {
        _busDal.Add(bus);
        return new SuccessResult(Messages.BusAdded);
    }

    public IResult Update(Bus bus)
    {
        _busDal.Update(bus);
        return new SuccessResult(Messages.BusUpdated);
    }

    public IResult Delete(Guid id)
    {
        _busDal.Delete(new Bus { Id = id});
        return new SuccessResult(Messages.BusDeleted);
    }
}