using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DbQueryModel
{
    public class UserInfoViewModel
    {
     
        public int Id { get; set; }

        [Required]
        [Display(Name = "用户号")]
        public string UserName { get; set; }

        [Required] // cshtml 的 验证 为密码 必须填写
        [StringLength(100, ErrorMessage = "{0} 必须至少包含 {2} 个字符。", MinimumLength = 3)]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        [Compare("Password", ErrorMessage = "密码和确认密码不匹配。")]
        public string ConfirmPassword { get; set; }

        public bool DelFlag { get; set; }

        [Display(Name = "真实姓名")]
        public string RealName { get; set; }

        [Display(Name = "权限号")]
        public int UserPrivilegesId { get; set; }

        [Display(Name = "权限名")]
        public string UserPrivilegesName { get; set; }
    }
}
