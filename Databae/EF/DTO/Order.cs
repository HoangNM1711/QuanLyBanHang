namespace Database.EF.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(250)]
        public string CustomerAddress { get; set; }

        [StringLength(50)]
        public string CustomerPhone { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
