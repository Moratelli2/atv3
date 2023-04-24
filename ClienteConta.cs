using System.Text.Json;

namespace AtvSalaPOO
{
    class ClienteConta
    {
        public Cliente Cliente { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public DateTime Data { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
