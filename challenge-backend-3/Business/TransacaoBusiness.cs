using challenge_backend_3.Business.Interfaces;
using challenge_backend_3.Models;

namespace challenge_backend_3.Business
{
    public class TransacaoBusiness : ITransacaoBusiness
    {
        public List<Transacao> ExtrairTransacoes()
        {
            var linhasExtraidas = new List<string>();

            foreach (var conteudo in linhasExtraidas)
            {
                var novaTransacao = new Transacao();
                //novaTransacao.BancoDestino = conteudo.

            }




            throw new NotImplementedException();
        }
    }
}
