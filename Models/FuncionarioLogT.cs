using System.Text.Json;

namespace TrilhaNetAzureDesafio.Models
{
    public class FuncionarioLogT
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Ramal { get; set; }
        public string EmailProfissional { get; set; }
        public string Departamento { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public TipoAcao TipoAcao { get; set; }
        public string JSON { get; set; }
        public DateTime DataLog { get; set; } = DateTime.UtcNow;

        public FuncionarioLogT() { }

        public FuncionarioLogT(Funcionario funcionario, TipoAcao tipoAcao)
        {
            FuncionarioId = funcionario.Id;
            Nome = funcionario.Nome;
            Endereco = funcionario.Endereco;
            Ramal = funcionario.Ramal;
            EmailProfissional = funcionario.EmailProfissional;
            Departamento = funcionario.Departamento;
            Salario = funcionario.Salario;
            DataAdmissao = funcionario.DataAdmissao?.DateTime ?? DateTime.UtcNow;
            TipoAcao = tipoAcao;
            JSON = JsonSerializer.Serialize(funcionario);
        }
    }
}