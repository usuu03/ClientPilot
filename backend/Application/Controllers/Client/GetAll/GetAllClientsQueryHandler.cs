using System;
using Application.Common;
using Application.Controllers.Client.Models;
using Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Application.Controllers.Client.GetAll;

public class GetAllClientsQueryHandler : BaseHandler, IRequestHandler<GetAllClientQuery, ClientVm>
{
    public GetAllClientsQueryHandler(AppDbContext db) : base(db)
    {
    }

    public async Task<ClientVm> Handle(GetAllClientQuery request, CancellationToken cancellationToken)
    {
        ClientVm clientVm = new ClientVm();

        var clients = await Db.Clients
            .AsNoTracking()
            .Select(c => new ClientDto()
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone,
                Address = c.Address,
                BusinessName = c.BusinessName,
                HasLeftReview = c.HasLeftReview,
                LastReviewDate = c.LastReviewDate,
                CreatedAt = c.CreatedAt
            }).ToListAsync(cancellationToken);

        clientVm.Clients = clients;
        return clientVm;
    }

}
