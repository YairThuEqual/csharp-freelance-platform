using FreelancePlatform.Forms.FreelancerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreelancePlatform.GetterSetter
{
    public class CompleteProject
    {
        public int BidId { get; set; }
        public string Title { get; set; }
        public string Budget { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public byte[] Image { get; set; }
        public string Date {  get; set; }
        public FreelancerProfile Profile { get; set; }
        public string FreelancerName { get; set; }
        public byte[] FreelancerImgae { get; set; }
        public string Name { get; set; }
        public byte[] ProfileImgae { get; set; }
    }
}
