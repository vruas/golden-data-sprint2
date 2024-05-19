using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenData.Models
{
    [Table("CADASTRO_CONSUMIDOR")]
    public class CadastroConsumidor
    {
        [Key]
        [Column("ID_CONS")]
        public int Id { get; set; }

        [Required]
        [Column("EML_CONS")]
        public string EmailConsumidor { get; set; }

        [Required]
        [Column("SENHA_CONS")]
        public string SenhaConsumidor { get; set; }

        [Required]
        [Column("CPF_CONS")]
        public string CpfConsumidor { get; set; }

        [Required]
        [Column("NM_CONS")]
        public string NomeConsumidor { get; set; }

        [Required]
        [Column("GEN_CONS")]
        public string GeneroConsumidor { get; set; }

        [Required]
        [Column("DT_NASC_CONS")]
        public string DataNascimentoConsumidor { get; set; }

        [Required]
        [Column("EST_CONS")]
        public string EstadoConsumidor { get; set; }

    }
}
