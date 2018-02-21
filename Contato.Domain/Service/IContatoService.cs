﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contrato.Domain.Service
{
    public interface IContatoService
    {
        Contato Get(Guid id);
        void Update(Contato contato);
        void Delete(Guid id);
        IEnumerable<Contato> List(int page, int size);
    }
}