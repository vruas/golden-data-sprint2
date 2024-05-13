using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenData.Models
{
    [Table("CADASTRO_EMPRESA")]
    public class CadastroEmpresa
    {
        [Key]
        [Column("ID_EMPRESA")]
        public int Id { get; set; }

        [Required]
        [Column("CNPJ_EMP")]
        public string CNPJ { get; set; }

        [Required]
        [Column("EMAIL_EMP")]
        public string EmailEmpresa { get; set; }

        [Required]
        [Column("SENHA_EMPRESA")]
        public string SenhaEmpresa { get; set; }

        [Required]
        [Column("RZ_SOCIAL")]
        public string RazaoSocial { get; set; }
    }
}
