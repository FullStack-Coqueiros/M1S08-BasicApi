using Basic_Api.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder();

var app = builder.Build();

app.MapGet("/Clientes/", ([FromQuery]string nome) => Results.Ok("Olá, "+ nome)); 

app.MapGet("/Clientes/{id}", ([FromQuery]string nome, [FromRoute]int id) => "Olá, "+ nome+ " O Seu id é "+ id); 

app.MapGet("/Clientes/id/{id}", ([FromQuery]string nome, [FromRoute]int id) => Results.Ok(new Cliente(id, nome))); 


var carros = new List<string>();
carros.Add("Gol");
carros.Add("Ferrari");
carros.Add("Fiesta");

//app.MapGet("/veiculos/", () => Results.Ok(carros));
// A linha acima é um resumo da linha de baixo
// app.MapGet("/veiculos/", () => { 
//     return Results.Ok(carros);
//   });


// A linha acima é um resumo da linha de baixo
app.MapGet("/veiculos/", ([FromQuery]string carro) => { 
    if (string.IsNullOrEmpty(carro)){
      return Results.Ok(carros);
    }

    if (carros.Exists(x => x == carro)){
      return Results.Ok("Carro Cadastrado");
    }
    else {
      return Results.NoContent();
    }
  
  });

app.MapPost("/veiculos/", ([FromQuery]string carro) => {
  carros.Add(carro);
  return Results.Ok();
});

app.MapDelete("/veiculos/", ([FromQuery]string carro) => {
  carros.Remove(carro);
  return Results.Ok();
});


app.Run();