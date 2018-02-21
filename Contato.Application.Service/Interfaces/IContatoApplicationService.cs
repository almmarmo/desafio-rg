using Contato.Application.Service.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contato.Application.Service
{
    public interface IContatoApplicationService
    {
        ContatoGetResponseMessage Get(string id);
    }
}
