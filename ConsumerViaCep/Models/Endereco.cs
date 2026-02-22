using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ConsumerViaCep.Models
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        public string Ddd { get; set; }
        public string Siafi { get; set; }
    }
}