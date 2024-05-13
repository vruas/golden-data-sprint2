using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenData.Models
{
    [Table("CADASTRO_CONSUMIDOR")]
    public class CadastroConsumidor
    {
        [Key]
        [Column("ID_CONSUMIDOR")]
        public int Id { get; set; }

        [Required]
        [Column("EMAIL_CONSUMIDOR")]
        public string EmailConsumidor { get; set; }

        [Required]
        [Column("SENHA_CONSUMIDOR")]
        public string SenhaConsumidor { get; set; }

        [Required]
        [Column("CPF_CONSUMIDOR")]
        public string CpfConsumidor { get; set; }

        [Required]
        [Column("NM_CONSUMIDOR")]
        public string NomeConsumidor { get; set; }

        [Required]
        [Column("GENERO_CONSUMIDOR")]
        public string GeneroConsumidor { get; set; }

        [Required]
        [Column("DT_NASC_CONS")]
        public string DataNascimentoConsumidor { get; set; }

        [Required]
        [Column("ESTADO_CONSUMIDOR")]
        public string EstadoConsumidor { get; set; }

    }
}
