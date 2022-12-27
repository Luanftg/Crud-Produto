using System.Diagnostics;
using database.mysql;
using Microsoft.AspNetCore.Mvc;
using negocio.models;
using negocio.services;
using web.Models;

namespace web.Controllers;

public class HomeController : Controller
{

    ProdutoServico produtoServico = new ProdutoServico(new RepositorioMYSQL<Produto>());
    
    public IActionResult Index()
    {
        var listaDeProdutos = produtoServico.BuscarTodos();
        int? quantidadeDeProdutos = listaDeProdutos.Count();
        int quantidade = 0;
        foreach (Produto produto in listaDeProdutos)
        {
            quantidade += produto.Quantidade;
        }
        int? quantidadeDeItensNoEstoque = quantidade;
        ViewBag.quantidadeDeProdutos = quantidadeDeProdutos;
        ViewBag.quantidadeDeItensNoEstoque = quantidadeDeItensNoEstoque;
        return View();
    }

}
