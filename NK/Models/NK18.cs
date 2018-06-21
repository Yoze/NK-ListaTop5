namespace NK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NK18
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KPSIFRA { get; set; }

        [StringLength(20)]
        public string IME { get; set; }

        [StringLength(1)]
        public string PZP { get; set; }

        [StringLength(20)]
        public string MESTO { get; set; }

        public double? SumOfUKUPNO { get; set; }
    }
}
