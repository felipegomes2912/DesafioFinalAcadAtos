using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalAcadNet.Models;

public partial class Instrumento
{
    [Column("id")]
    [Display(Name = "Código")]
    public int Id { get; set; }

    [Column("nome")]
    [Display(Name = "Nome")]
    public string Nome { get; set; } = null!;

    [Column("marca")]
    [Display(Name = "Marca")]
    public string Marca { get; set; } = null!;

    [Column("descricao")]
    [Display(Name = "Modelo")]
    public string? Descricao { get; set; }

    [Column("cor")]
    [Display(Name = "Cor")]
    public string? Cor { get; set; }

    [Column("peso")]
    [Display(Name = "Peso (g)")]
    public int Peso { get; set; }

    [Column("dataFabricado")]
    [Display(Name = "Data de registro no sistema")]
	[DataType(DataType.Date)]
	[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
	public DateTime DataFabricado { get; set; }

    [Column("qntdEstoque")]
    [Display(Name = "Quantidade em estoque")]
    public int QntdEstoque { get; set; }

    [Column("sopro")]
    [Display(Name = "Sopro")]
    public bool Sopro { get; set; }

    [Column("corda")]
    [Display(Name = "Corda")]
    public bool Corda { get; set; }

    [Column("percursao")]
    [Display(Name = "Percursão")]
    public bool Percursao { get; set; }
}
