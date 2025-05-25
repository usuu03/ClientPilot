using System;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class ClientController(AppDbContext context) : BaseApiController
{
    // GET: api/clients
    [HttpGet]
    public async Task<IActionResult> GetClients()
    {
        var clients = await context.Clients.ToListAsync();
        return Ok(clients);
    }

    // GET: api/clients/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetClient(int id)
    {
        var client = await context.Clients.FindAsync(id);
        if (client == null) return NotFound();
        return Ok(client);
    }


}
