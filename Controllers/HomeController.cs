using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPets.Models;

namespace LHPets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancia tipo cliente
        Cliente cliente1 = new Cliente(01, "Iran Pacheco Jr", "950.401.874-22", "iranpacheco@gmail.com", "Irak");
        Cliente cliente2 = new Cliente(02, "Aghata Lais", "220.532.464-10", "aghata@gmail.com", "Aghata");
        Cliente cliente3 = new Cliente(03, "Rita de Cássia Caetano ", "894.222.565-87", "ritacaetano@gmail.com", "Rita Caetano");
        Cliente cliente4 = new Cliente(04, "Bruno F Pacheco", "650.845.964-78", "brunopacheco@gmail.com", "BPacheco");
        Cliente cliente5 = new Cliente(05, "Fabiana F Pacheco", "101.320.474-65", "fabianapacheco@gmail.com", "Fabi");
        
        //lista tipo cliente
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //instancia tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Cãozinho", "15.453.784/0001-80", "caozinho@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "GatoMia", "68.455.456/0001-80", "gatomia@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "CãoPet", "54.767.018/0001-42", "caopet@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "AquarioMeu", "98.174.644/0001-09", "aquariomeu@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Alpíste", "24.718.486/0001-66", "alpiste@gmail.com");

        //lista tipo fornecedor
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
