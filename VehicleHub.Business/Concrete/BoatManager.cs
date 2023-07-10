using VehicleHub.Business.Abstract;
using VehicleHub.Business.Constants;
using VehicleHub.Core.Utilities.Results;
using VehicleHub.DataAccess.Abstract;
using VehicleHub.Entities.Concrete;

namespace VehicleHub.Business.Concrete;

public class BoatManager:IBoatService
{
    private readonly IBoatDal _boatDal;

    public BoatManager(IBoatDal boatDal)
    {
        _boatDal = boatDal;
    }
    public IDataResult<List<Boat>> GetAll()
    {
        return new SuccessDataResult<List<Boat>>(_boatDal.GetAll(), Messages.BoatsListed);
    }

    public IDataResult<List<Boat>> GetByColor(string color)
    {
        return new SuccessDataResult<List<Boat>>(_boatDal.GetAll(b => b.Color.ToLower() == color.ToLower()), Messages.BoatsListedColor);
    }

    public IDataResult<Boat> GetById(Guid id)
    {
        return new SuccessDataResult<Boat>(_boatDal.Get(b => b.Id == id), Messages.BoatListed);
    }

    public IResult Add(Boat boat)
    {
        _boatDal.Add(boat);
        return new SuccessResult(Messages.BoatAdded);
    }

    public IResult Update(Boat boat)
    {
        _boatDal.Update(boat);
        return new SuccessResult(Messages.BoatUpdated);
    }

    public IResult Delete(Guid id)
    {
        _boatDal.Delete(new Boat { Id = id});
        return new SuccessResult(Messages.BoatDeleted);
    }
}