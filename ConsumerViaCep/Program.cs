using static System.Console;

WriteLine("Digite o CEP para consulta:");
string cep = ReadLine();

var enderecoUrl = $"https://viacep.com.br/ws/{cep}/json/";

WriteLine($"Consultando o endereço para o CEP: {cep}...");

var httpClient = new HttpClient();

try
{
  HttpResponseMessage? response = await httpClient.GetAsync(enderecoUrl);
  response.EnsureSuccessStatusCode();

  string responseBody = await response.Content.ReadAsStringAsync();
  
  var endereco = System.Text.Json.JsonSerializer.Deserialize<ConsumerViaCep.Models.Endereco>(responseBody);
  WriteLine($"Endereço encontrado: {endereco.Logradouro}, {endereco.Bairro}, {endereco.Localidade} - {endereco.Uf}");
}
catch (System.Exception)
{
  WriteLine("Ocorreu um erro ao consultar o endereço. Verifique o CEP e tente novamente.");
}