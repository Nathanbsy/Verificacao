namespace VerificacaoRotinas.Models
{
    public class Rotina
    {
        public string Descricao { get; set; }
        public string Cliente { get; set; }
        public string InstrucaoSQL { get; set; }
        public DateTime DataHora { get; set; }
        public string Apelido { get; set; }
        public int Tolerancia { get; set; }
    }
}
