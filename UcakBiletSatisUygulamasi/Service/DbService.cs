using FlightTicketMatic_V2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlightTicketMatic_V2.Models;
using static System.Collections.Specialized.BitVector32;
using Microsoft.EntityFrameworkCore;


namespace FlightTicketMatic_V2.Service
{
    internal class DbService
    {
        private readonly AppDbContext _dbContext = new AppDbContext();

        public async Task<List<T>> GetAll<T>() where T : class
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<List<object>> GetAllIds<T>() where T : class
        {
            var entities = await _dbContext.Set<T>().ToListAsync();
            var idProperty = typeof(T).GetProperty("id");
            if (idProperty == null)
            {
                throw new InvalidOperationException($"Type {typeof(T).Name} does not have an id property.");
            }

            return entities.Select(e => idProperty.GetValue(e)).ToList();
        }
        public T GetEntityById<T>(int entityId) where T : class
        {
            var dbSet = _dbContext.Set<T>();

            // Assuming "id" is the name of the primary key property
            var entity = dbSet.FirstOrDefault(e => EF.Property<int>(e, "id") == entityId);

            return entity;
        }

        public async Task<List<string>> GetToByFrom(string from)
        {
            var toLocationsList = await _dbContext.Set<Flight>()
                                        .Where(f => f.fromLocation == from)
                                        .Select(f => f.toLocation)
                                        .Distinct()
                                        .ToListAsync();
            return toLocationsList;
        }

        public async Task<List<Flight>> GetFlight(string from_location, string to_location)
        {
            var flightList = await _dbContext.Flights
                                     .Where(flight => flight.fromLocation == from_location && flight.toLocation == to_location)
                                     .ToListAsync();

            return flightList;
        }

        public Reservation GetReservedSeatsNoBasedOnFlightId(int flight_id)
        {
            return _dbContext.Reservations
                        .FirstOrDefault(f => f.flightId == flight_id);
        }

        public List<string> GetOccupiedSeatsNoBasedOnFlightId(int flightId)
        {
            var seatNos = _dbContext.Reservations
                                  .Where(f => f.flightId == flightId)
                                  .Select(s => s.seatNo)
                                  .ToList();
            return seatNos;
        }
    }
}
