using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models;

// prop cria metodos get e set ex: public double Preco{ get; set; }

public class Funcionario{

public String? Id {get; set;}
[Required(ErrorMessage = "Este Campo é Obrigatório!")]

public String? Nome {get; set;}
public int? cpf {get; set;}

public Funcionario(String nome,String Id)
{
    Nome = nome;
    Id = 1;
}
}



internal class ErrorMessageAttribute : Attribute
{
}

//LocalHost http://localhost:5054