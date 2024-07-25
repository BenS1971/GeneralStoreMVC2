using Microsoft.AspNetCore.Mvc;
using GeneralStoreMVC2.Data;
using GeneralStoreMVC2.Models.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GeneralStoreMVC2.Controllers;

public class CustomerController : Controller;

    private readonly GeneralStoreDb2Context _ctx;

    public CustomerController(GeneralStoreDb2Context dbContext)
    {
        _ctx = dbContext;
    }

    public async Task<IActionResult> Index()
    {
    List<CustomerIndexViewModel> customers = await _ctx.Customers
    .Select(CustomerController => new CustomerIndexViewModel
    {
        ID = customer.Id,
        Name = customer.Name,
        Email = customer.Email
    })
    .ToListAsync();

    return View(customers);
    }



