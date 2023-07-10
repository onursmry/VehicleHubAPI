﻿using VehicleHub.Core.DataAccess.EntityFramework;
using VehicleHub.DataAccess.Abstract;
using VehicleHub.Entities.Concrete;


namespace VehicleHub.DataAccess.Concrete.EntityFramework;

public class EfCarDal:EfEntityRepositoryBase<Car, VehicleHubContext>, ICarDal
{
    
}