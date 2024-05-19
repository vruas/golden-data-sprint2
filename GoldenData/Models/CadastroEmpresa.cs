using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenData.Models
{
    [Table("CADASTRO_EMPRESA")]
    public class CadastroEmpresa
    {
        [Key]
        [Column("ID_EMP")]
        public int Id { get; set; }

        [Required]
        [Column("CNPJ_EMP")]
        public string CNPJ { get; set; }

        [Required]
        [Column("EML_EMP")]
        public string EmailEmpresa { get; set; }

        [Required]
        [Column("SENHA_EMP")]
        public string SenhaEmpresa { get; set; }

        [Required]
        [Column("RZ_SOCIAL_EMP")]
        public string RazaoSocial { get; set; }
    }
}
