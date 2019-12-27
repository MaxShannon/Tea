using System.ComponentModel.DataAnnotations;

namespace Model.DbQueryModel
{
    public class UserPrivilegeInfoViewModel
    {

        public int Id { get; set; }

        [Display(Name = "权限名")]
        public string PrivilegeName { get; set; }
    }
}