using Newtonsoft.Json;
using tipos_anonimos.Models;

// Extensions 

// int numero =  1;

// // chama método extendido do tipo 
// Console.WriteLine($"{(numero.EhPar() ? "é par " : "é ímpar")}" );


//TIPOS GENERICOS

// MeuArray<int> array = new MeuArray<int>();

// array.AdicionaElementoArray(1);
// array.AdicionaElementoArray(2);
// array.AdicionaElementoArray(3);
// array.AdicionaElementoArray(4);
// array.AdicionaElementoArray(5);
// array.AdicionaElementoArray(6);
// array.AdicionaElementoArray(7);
// array.AdicionaElementoArray(8);
// array.AdicionaElementoArray(9);
// array.AdicionaElementoArray(10);
// array.AdicionaElementoArray(11);

// array[9] = 12;

// Console.WriteLine(array[9]);

//TIPOS ANONIMOS 

// string arquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda>? lista = JsonConvert.DeserializeObject<List<Venda>>(arquivo);

// var listaAnonimo = lista.Select(x => new {x.Id, x.Produto});

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"nome: {venda.Produto}, ID: {venda.Produto}");
// }
 

// var tipoAnonimo = new {Nome="nome", Sobrenome="sobre", idade=12};

// Console.WriteLine($"nome:{tipoAnonimo.Nome} - sobrenome: {tipoAnonimo.Sobrenome} - idade: {tipoAnonimo.idade}");
