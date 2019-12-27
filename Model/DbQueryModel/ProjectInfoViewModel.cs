namespace Model.DbQueryModel
{
    public class ProjectInfoViewModel
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectId { get; set; }
        public bool DelFlag { get; set; }
        public int? UserId { get; set; }
        public string DutyName { get; set; }
    }
}