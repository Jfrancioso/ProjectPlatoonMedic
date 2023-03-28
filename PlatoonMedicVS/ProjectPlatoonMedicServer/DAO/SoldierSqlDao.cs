using System;
using System.Collections.Generic;
using System.Linq;
using ProjectPlatoonMedicServer.Models;

namespace ProjectPlatoonMedicServer.DAO
{
    public class SoldierDAO
    {
        private List<Soldier> _soldiers;

        public SoldierDAO()
        {
            // Initialize the list of soldiers
            _soldiers = new List<Soldier>();
        }

        public void AddSoldier(Soldier soldier)
        {
            // Add the soldier to the list
            _soldiers.Add(soldier);
        }

        public void RemoveSoldier(Soldier soldier)
        {
            // Remove the soldier from the list
            _soldiers.Remove(soldier);
        }

        public List<Soldier> GetAllSoldiers()
        {
            // Return the list of soldiers
            return _soldiers;
        }

        public Soldier GetSoldierById(Guid id)
        {
            // Find the soldier in the list by ID
            return _soldiers.FirstOrDefault(s => s.Id == id);
        }
    }
}
