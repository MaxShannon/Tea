namespace Model.DbQueryModel
{
    public class CargoInfoViewModel
    {
        public int Id { get; set; }
        public string CargoName { get; set; }
        public string Unit { get; set; }
        public decimal CargoCount { get; set; }
        public decimal? Amount { get; set; }
        public bool DelFlag { get; set; }
        public string Specifications { get; set; }
        public string Type { get; set; }
        public string LastCargoName { get; set; }
        public string Area { get; set; }
        public bool CanDel { get; set; }

    }
}