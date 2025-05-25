using System;

namespace Application.Controllers.Client.Models;

public record class ClientVm
{
    public List<ClientDto> Clients { get; set; } = new();

}
