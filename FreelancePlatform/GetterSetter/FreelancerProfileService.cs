using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.GetterSetter
{
    public class FreelancerProfileService
    {

        public int FreeProfileId { get; set; }
        public int FreelancerId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Profession { get; set; }
        public string? Bio { get; set; }
        public byte[]? Image { get; set; }
    }
}
