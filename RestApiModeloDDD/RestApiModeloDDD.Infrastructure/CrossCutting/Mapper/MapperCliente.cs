using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Infrastructure.CrossCutting.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.CrossCutting.Mapper
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto dto)
        {
            var cliente = new Cliente
            {
                Id = dto.Id.Value,
                Nome = dto.Nome,
                Sobrenome = dto.Sobrenome,
                Email = dto.Email
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var dto = new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return dto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c =>
                    new ClienteDto
                    {
                        Id = c.Id,
                        Nome = c.Nome,
                        Sobrenome = c.Sobrenome,
                        Email = c.Email
                    }
                );

            return dto;
        }
    }
}
