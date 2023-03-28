using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace ProjectPlatoonMedicServer.Models
{
    public class MedicalRecord
    {
        public Guid MedicalRecordId { get; set; }
        public Guid SoldierId { get; set; }
        public string MedicalCondition { get; set; }
        public string Treatment { get; set; }
        public string Prescription { get; set; }
        public Guid MedicalStatusUpdatedBy { get; set; }
        public DateTime MedicalStatusUpdatedOn { get; set; }
    }
}
