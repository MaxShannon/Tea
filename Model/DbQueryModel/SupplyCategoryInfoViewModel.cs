namespace Model.DbQueryModel
{
    public class SupplyCategoryInfoViewModel : SupplyCategoryInfo
    {
        public string SupplyInfoName { get; set; }

        public string CategoryInfoName { get; set; }
    }

    public enum SupplyOrCategory
    {
        Supply = 1,
        Category = 2
    }
}