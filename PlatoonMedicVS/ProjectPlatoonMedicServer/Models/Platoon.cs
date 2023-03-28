using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ProjectPlatoonMedicServer.Models
{
    public class Platoon
    {
        public int PlatoonId { get; set; }
        public string PlatoonName { get; set; }
        public Guid PlatoonLeaderId { get; set; }
        public int CompanyId { get; set; }
    }
}
