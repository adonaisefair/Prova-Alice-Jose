using System;
using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Folha{

    publiic float Valor{get; set;}
    public int Quantidade{get; set;}
    public int Mes{get; set;}
    public int Ano{get; set;}
    public int FuncionarioId{get; set;}
    public float salarioBruto{get; set;}
    public float impostIrrf{get; set;}
    public float impostoInss{get; set;}
    public float impostoFgts{get; set;}
    public float salarioLiquido{get; set;}
    