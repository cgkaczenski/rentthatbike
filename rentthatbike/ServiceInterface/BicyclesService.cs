using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using RentThatBike.Web.ServiceModel;
using RentThatBike.Web.ServiceModel.Types;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace RentThatBike.Web.ServiceInterface
{
    [Authenticate]
    public class BicyclesService : IService
    {
        /* This is to test the spinner animation for long load times
        public BicyclesService() {
            Thread.Sleep(2000);
        }
        */

        public BicycleRepository BicycleRepository { get; set; }

        public List<Bicycle> Get(GetBicycles request)
        {
            // This is to test displaying Server Errors to client
            //throw new Exception("Get bicycles list failed");
            return BicycleRepository.GetAll().ToList();
        }

        public Bicycle Get(GetBicycle request)
        {
            return BicycleRepository.Single(b => b.Id == request.Id);
        }

        public Bicycle Post(Bicycle request)
        {
            BicycleRepository.Add(request);
            return request;
        }

        public Bicycle Put(Bicycle request)
        {
            Bicycle bicycle = BicycleRepository.Single(b => b.Id == request.Id);
            bicycle.Name = request.Name;
            bicycle.Type = request.Type;
            bicycle.Quantity = request.Quantity;
            bicycle.RentPrice = request.RentPrice;
            return bicycle;
        }
    }
} 