namespace Entry
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        public string Photo { get; set; }

        public string Role { get; set; }

        public int? Branch_Id { get; set; }

        public int? Department_Id { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Department Department { get; set; }
    }
}
