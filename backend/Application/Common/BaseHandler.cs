using System;
using Infrastructure.Data;

namespace Application.Common;

public abstract class BaseHandler
{
    protected readonly AppDbContext Db;

    protected BaseHandler(AppDbContext db)
    {
        Db = db ?? throw new ArgumentNullException(nameof(db));
    }

}
