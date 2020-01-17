using System.Dynamic;

namespace Model.DbQueryModel
{
    public class SupplyInfoViewModel
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string SupplyName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool DelFlag { get; set; }
        public bool CanDel { get; set; }

        //public int CategoryInfoId { get; set; }
    }
}