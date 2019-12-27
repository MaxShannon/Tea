using System;

namespace Model.DbQueryModel
{
    public class CategoryInfoViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public bool? DelFlag { get; set; }
        public bool? CanDel { get; set; }
    }
}