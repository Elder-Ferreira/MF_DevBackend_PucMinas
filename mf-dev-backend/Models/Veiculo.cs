using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public int Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o placa!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricação!")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano do Modelo!")]
        public int AnoModelo { get; set; }
    }
}
