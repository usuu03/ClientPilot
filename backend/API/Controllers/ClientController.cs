using System;
using Application.Controllers.Client.GetAll;
using Application.Controllers.Client.Models;
using Domain;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class ClientController(AppDbContext context) : BaseApiController
{
    // GET: api/clients
    [HttpGet]
    public Task<ClientVm> GetClients()
    {
        return Mediator.Send(new GetAllClientQuery());
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
