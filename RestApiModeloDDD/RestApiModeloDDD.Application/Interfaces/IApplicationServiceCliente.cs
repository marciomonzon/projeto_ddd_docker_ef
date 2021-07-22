using RestApiModeloDDD.Application.Dtos;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto cliente);
        void Update(ClienteDto cliente);
        void Remove(ClienteDto cliente);
        IEnumerable<ClienteDto> GetAll();
        ClienteDto GetById(int id);
    }
}
