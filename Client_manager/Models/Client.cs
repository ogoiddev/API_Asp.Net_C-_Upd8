using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Client_manager.Models;
public class ClientModel
{
  public int Id { get; set; }
  public int Cpf { get; set; }
  public string Nome { get; set; }
  public char Sexo { get; set; }
  public string Estado { get; set; }
  public string Cidade { get; set; }
  public string Endereco { get; set; }

  public ClientModel(string nome, string estado, string cidade, string endereco)
  {
    Nome = nome;
    Estado = estado;
    Cidade = cidade;
    Endereco = endereco;
  }
}