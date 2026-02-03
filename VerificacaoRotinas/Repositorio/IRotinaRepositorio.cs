using VerificacaoRotinas.Models;

namespace VerificacaoRotinas.Repositorio
{
    public interface IRotinaRepositorio
    {
        List<Rotina> LerTxt(string caminho);
    }
}
