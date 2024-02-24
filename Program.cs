using Newtonsoft.Json;
using tipos_anonimos.Models;

string arquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda>? lista = JsonConvert.DeserializeObject<List<Venda>>(arquivo);

var listaAnonimo = lista.Select(x => new {x.Id, x.Produto});

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"nome: {venda.Produto}, ID: {venda.Produto}");
}


// var tipoAnonimo = new {Nome="nome", Sobrenome="sobre", idade=12};

// Console.WriteLine($"nome:{tipoAnonimo.Nome} - sobrenome: {tipoAnonimo.Sobrenome} - idade: {tipoAnonimo.idade}");
