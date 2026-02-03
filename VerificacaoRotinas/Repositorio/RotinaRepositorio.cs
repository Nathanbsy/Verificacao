using VerificacaoRotinas.Models;

namespace VerificacaoRotinas.Repositorio
{
    public class RotinaRepositorio : IRotinaRepositorio
    {
        public List<Rotina> LerTxt(string caminho)
        {
            List<Rotina> lista = new List<Rotina>();

            if (!File.Exists(caminho))
                return lista;

            var linhas = File.ReadAllLines(caminho);

            Rotina rotinaAtual = new Rotina();

            foreach (var linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                {
                    if (!string.IsNullOrEmpty(rotinaAtual.Descricao))
                    {
                        lista.Add(rotinaAtual);
                        rotinaAtual = new Rotina();
                    }
                    continue;
                }

                if (linha.StartsWith("Descrição:"))
                    rotinaAtual.Descricao = linha.Replace("Descrição:", "").Trim();

                else if (linha.StartsWith("Cliente:"))
                    rotinaAtual.Cliente = linha.Replace("Cliente:", "").Trim();

                else if (linha.StartsWith("Instrução SQL:"))
                    rotinaAtual.InstrucaoSQL = linha.Replace("Instrução SQL:", "").Trim();

                else if (linha.StartsWith("Apelido:"))
                    rotinaAtual.Apelido = linha.Replace("Apelido:", "").Trim();

                else if (linha.StartsWith("Tolerância:"))
                {
                    var valor = linha.Replace("Tolerância:", "").Trim();
                    rotinaAtual.Tolerancia = int.Parse(valor);
                }
            }

            if (!string.IsNullOrEmpty(rotinaAtual.Descricao))
                lista.Add(rotinaAtual);

            return lista;
        }
    }
}
