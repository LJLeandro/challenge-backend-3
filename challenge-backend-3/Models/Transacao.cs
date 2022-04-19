namespace challenge_backend_3.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public string BancoOrigem { get; set; }
        public string AgenciaOrigem { get; set; }
        public string ContaOrigem { get; set; }
        public string BancoDestino { get; set; }
        public string AgenciaDestino { get; set; }
        public string ContaDestino { get; set; }
        public double Valor { get; set; }
        public DateTime DataHora { get; set; }
    }
}
