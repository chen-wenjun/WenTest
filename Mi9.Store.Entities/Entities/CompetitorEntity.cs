using System;

namespace Mi9.Store.Entities.Entities
{
    public class CompetitorEntity
    {
        public int RivalNo { get; set; }
        public string NAME { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public bool Important { get; set; }
        public char StatusCode { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int CreateUser { get; set; }
    }
}
