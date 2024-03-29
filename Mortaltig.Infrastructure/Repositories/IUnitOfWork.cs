﻿using Mortaltig.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortaltig.Infrastructure.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
        Task CompleteAsync(CancellationToken token);
    }
}
