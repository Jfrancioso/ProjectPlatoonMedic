using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace ProjectPlatoonMedicServer.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Guid CompanyCommanderId { get; set; }
    }
}
