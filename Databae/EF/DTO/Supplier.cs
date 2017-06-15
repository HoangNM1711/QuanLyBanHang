namespace Database.EF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Stock { get; set; }

        public int? Sold { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
