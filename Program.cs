using System.ComponentModel.DataAnnotations;
using API.Models;
using Microsoft.AspNetCore.Mvc;


var builder = WebApplication.CreateBuilder(args);

global::System.Object value = builder.Services.AddDbContext<AppDataContext>();
List<Funcionario>funcionarios = new List<Funcionario>();
List<Folha>folhas = new List<Funcionario>();

var app = builder.Build();
app.MapGet("/", () => "Prova 29/04/24");
//Alice Gabriele Rodrigues Martins Soares,Jose Adonai Sefair de Sales

//POST http://localhost:5054/api/funcionario/cadastrar
app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionario,[FromServices] AppDataContext context) =>
{
    Funcionario? funcionarioBuscado = context.Funcionario.FirstOrDefault(x => x.Nome == funcionario.Nome);
    if(funcionarioBuscado is null){
    funcionario.Nome = funcionario.Nome.ToUpper();
    context.funcionarios.Add(funcionario);
    return Results.Created($"/api/funcionario/buscar/{funcionario.Id}", funcionario);
    funcionario.Id++;
    context.SaveChanges();
    }
    return Results.BadRequest("Existe um Funcionario com este nome");
});


// GET: http://localhost:5054/api/funcionario/listar
app.MapGet("/api/funcionario/listar",([FromServices] AppDataContext context) =>
{
    if(context.Funcionarios.Any())
    {
        return Results.Ok(context.Funcionario.ToList());
    }
    return Results.NotFound("Funcionario não encontrado");
    
});

//POST http://localhost:5054/api/folha/cadastrar
app.MapPost("/api/folha/cadastrar", ([FromBody] Folha folha,[FromServices] AppDataContext context) =>
{
    List<ValidationResult> erros = new List<ValidationResult>();
    if(!Validator.TryValidateObject(funcionario new ValidationContext(funcionarios),erros, true))
    {
        return Resultsglobal::System.Object value1 = .404(erros);
    }

    if(salarioBruto > 0 && salarioBruto <=  1.903,98){
        float irrf = 0;
        float impostoinss = salarioBruto*0,08;
        float impostofgts = salarioBruto*0,08

        return irrf,imposto,impostofgts;
    }
    else if(salarioBruto > 1.903,98 && salarioBruto <= 2.826,65)
    {
        float irrf = salarioBruto*0,075;
        float impostoinss = salarioBruto*0,08;
        float impostofgts = salarioBruto*0,09
        return irrf,imposto,impostofgts;
    }
    else if(salarioBruto > 2.826,65 && salarioBruto <= 3.751,05)
    {
        return ("Irrf: " (salarioBruto*0,15) + "Inss :" + (salarioBruto*0,11) +
        "FGTS : " + (salarioBruto*0,08) + "Salario Liquido : " + (salarioBruto*0,075*0,08));
    }
    else if(salarioBruto > 3.751,05 && salarioBruto <= 5.645,80)
    {
        return ("Irrf: " (salarioBruto*0,225) + "Inss :" + (salarioBruto*0,11) +
        "FGTS : " + (salarioBruto*0,08) + "Salario Liquido : " + (salarioBruto*0,075*0,08));
    }
    else
    {
        ("Irrf: " (salarioBruto*0,275) + "Inss : 621,03"+
        "FGTS : " + (salarioBruto*0,08) + "Salario Liquido : " + (salarioBruto*0,075*0,08));
        return folha.impostoIrrf.Add()
    }

    Folha? folhaBusca = context.Folhass.FirstOrDefault(x => x.Nome == folha.Nome);
    if(folhabusca is null){
    folha.Nome = folha.Nome.ToUpper();
    context.Folhas.Add(folha);
    context.SaveChanges();
    return Results.Created($"/api/folha/buscar/{folha.Id}", folha);
    }
    return Results.BadRequest("Ja existe uma folha");
});

// GET: http://localhost:5054/api/folha/listar
app.MapGet("/api/folha/listar",([FromServices] AppDataContext context) =>
{
    if (context.Folhas.Any() is null)
    {
        return Results.404(erros);
    }
    return Results.Ok(context.Funcionario.ToList());
});


// GET: http://localhost:5054/api/funcionario/buscar/{iddofuncionario}
app.MapGet("/api/funcionario/buscar/{id}", ([FromRoute] string id,[FromServices] AppDataContext context) =>
{
    Funcionario? funcionario = context.Funcionario.FirstOrDefault(p => p.Id == id);
    if(funcionario == null){
        return Results.NotFound("Funcionario não encontrado");
    }
    return Results.Ok(funcionario);
});


// PUT: http://localhost:5054/api/funcionario/alterar/{iddofuncionario}
app.MapPut("/api/funcionario/alterar/{id}", ([FromRoute] string id, [FromBody] Funcionario funcionarioAlterado
,[FromServices] AppDataContext context) =>
{
    Funcionario? funcionario = context.Funcionario.Find(id);

    if(funcionario == null){
        return Results.NotFound("Funcionario não encontrado");
    }
    funcionario.Nome = funcionarioAlterado.Nome;
    funcionario.Descricao = funcionarioAlterado.Descricao;
    funcionario.Preco = funcionarioAlterado.Preco;
    return Results.Ok("Funcionario alterado com sucesso!");

    context.Funcionarios.Update(funcionario);
    context.SaveChanges();
    return Results.Ok("Funcionario alterado com sucesso!");
});

// DELETE: http://localhost:5054/api/funcionario/deletar/{iddoproduto}
app.MapDelete("/api/funcionario/deletar/{id}", ([FromRoute] string id,[FromServices] AppDataContext context) =>
{
    Funcionario? funcionario = context.Funcionario.Find(id);

    if(funcionario == null){
        return Results.NotFound("Funcionario não encontrado");
    }
    context.Funcionarios.Remove(funcionario);
    context.SaveChanges();
    return Results.Ok(funcionario);
});

app.Run();

