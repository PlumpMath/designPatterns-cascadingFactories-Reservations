using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservations
{
    public class Program
    {
        static IServiceProvider InitializeIoCContainer()
        {
            return new ServiceCollection()
                .AddSingleton<IVacationPartFactory, VacationPartFactory>()
                .AddSingleton<IHotelSelector, HotelSelector>()
                .AddSingleton<IHotelService, HotelService>()
                .AddSingleton<IAirplaneService, AirplaneService>()
                .BuildServiceProvider();
        }

        public static void Main(string[] args)
        {
            var serviceProvider = InitializeIoCContainer();

            new Application(
                serviceProvider.GetService<IVacationPartFactory>())
            .Run();

            Console.ReadLine();
        }
    }
}
