using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InventoryERP.Web.Models;
using Microsoft.AspNetCore.Authorization;
using InventoryERP.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryERP.Web.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new DashboardViewModel
        {
            TotalProducts = await _context.Products.CountAsync(),
            TotalSales = await _context.Sales.SumAsync(s => (decimal?)s.Total) ?? 0,
            TotalPurchases = await _context.Purchases.SumAsync(p => (decimal?)p.TotalCost) ?? 0,
            LowStockProducts = await _context.Products
                .Include(p => p.Category)
                .Where(p => p.CurrentStock <= p.ReorderLevel)
                .ToListAsync()
        };
        
        viewModel.LowStockAlertCount = viewModel.LowStockProducts.Count;

        return View(viewModel);
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
