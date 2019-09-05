namespace FIT5032_Week05_CreatDateTable.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MOCK_DATA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string first_name { get; set; }

        [StringLength(50)]
        public string last_name { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string gender { get; set; }

        [StringLength(20)]
        public string ip_address { get; set; }
    }
}
