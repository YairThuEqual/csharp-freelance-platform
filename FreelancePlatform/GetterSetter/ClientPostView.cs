using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.GetterSetter
{
    public class ClientPostView
    {
        public int ClientPfId { get; set; }
        public int FreeProfileId { get; set; }
        public int PostId { get; set; }
        public string? ClientName { get; set; }
        public byte[]? ClientImage { get; set; }
        public string? Title { get; set; }
        public string? Budget { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }
        public int BidId { get; set; }
    }
}
