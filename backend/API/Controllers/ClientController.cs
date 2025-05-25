using System;
using Domain;
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
    public async Task<ActionResult<Client>> GetActivityDetail(string id)
    {
        if (!Guid.TryParse(id, out var guid))
            return BadRequest("Invalid GUID format.");
        var client = await context.Clients.FindAsync(guid);

        if (client == null)
        {
            return NotFound();
        }

        return client;
    }
    

}
