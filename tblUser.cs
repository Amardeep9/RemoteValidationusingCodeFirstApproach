namespace RemoteValidateExCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class tblUser
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(50)]
        [Remote("CheckUserName", "RemotrValidateEx", ErrorMessage ="Username already Exist")]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
