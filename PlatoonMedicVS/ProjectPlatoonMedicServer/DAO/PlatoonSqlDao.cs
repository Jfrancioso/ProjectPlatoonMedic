using System;
using System.Collections.Generic;
using System.Linq;
using ProjectPlatoonMedicServer.Models;

namespace ProjectPlatoonMedicServer.DAO
{
    public class PlatoonDAO
    {
        private readonly List<Platoon> _platoons = new List<Platoon>();

        public PlatoonDAO()
        {
            // Add some initial data
            _platoons.Add(new Platoon { Id = 1, Name = "Alpha" });
            _platoons.Add(new Platoon { Id = 2, Name = "Bravo" });
            _platoons.Add(new Platoon { Id = 3, Name = "Charlie" });
        }

        public List<Platoon> GetAll()
        {
            return _platoons;
        }

        public Platoon GetById(int id)
        {
            return _platoons.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Platoon platoon)
        {
            // Generate a new id based on the highest existing id
            platoon.Id = _platoons.Any() ? _platoons.Max(p => p.Id) + 1 : 1;
            _platoons.Add(platoon);
        }

        public void Update(Platoon platoon)
        {
            // Find the index of the existing platoon with the same id
            var index = _platoons.FindIndex(p => p.Id == platoon.Id);
            if (index != -1)
            {
                // Replace the existing platoon with the new platoon
                _platoons[index] = platoon;
            }
        }

        public void Delete(int id)
        {
            // Remove the platoon with the specified id
            _platoons.RemoveAll(p => p.Id == id);
        }
    }
}
