using System.Text.Json;

namespace AtvSalaPOO
{
    abstract class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
