using challenge_backend_3.Models;

namespace challenge_backend_3.Business.Interfaces
{
    public interface ITransacaoBusiness
    {
        public List<Transacao> ExtrairTransacoes();
    }
}
