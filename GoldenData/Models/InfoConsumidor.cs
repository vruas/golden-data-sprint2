using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenData.Models
{
    [Table("INFO_CONSUMIDOR")]
    public class InfoConsumidor
    {
        [Key]
        [Column("ID_INFO")]
        public int Id { get; set; }

        [Required]
        [Column("PREF_CPM_CLIE")]
        public string PrefCompra { get; set; }

        [Required]
        [Column("PREF_ANC")]
        public string PrefAnuncio { get; set; }

        [Required]
        [Column("MARCAS_EVITADAS")]
        public string MarcasEvitadas { get; set; }

        [Required]
        [Column("HOBBIES")]
        public string Hobbies { get; set; }

        [Required]
        [Column("ANC_EVITADOS")]
        public string AnunciosEvitados { get; set; }

        [Required]
        [Column("CMP_ON")]
        public string CompraOnline { get; set; }

    }
}
