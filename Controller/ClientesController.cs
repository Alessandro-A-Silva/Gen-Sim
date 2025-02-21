using AutoMapper;
using FluentValidation;
using Gen_Sim.Dto;
using Gen_Sim.Mapper;
using Gen_Sim.Model;
using Gen_Sim.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Controller
{
    public class ClientesController
    {   
        private Clientes? _cliente;
        private readonly IValidator<Clientes> _clientesValidator;
        IMapper _mapper;
        public ClientesController()
        {
            _clientesValidator = new ClientesValidator();
            MapperConfiguration _mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = _mapperConfiguration.CreateMapper();
        } 
        public bool Create(ClientesDto dto)
        {   
            _cliente = new Clientes()
            {
                Id = dto.Id,
                Bairro = dto.Bairro,
                Cep = dto.Cep,
                CnpjCpf = dto.CnpjCpf,
                Email = dto.Email,
                Estado = dto.Estado,
                InscricaoEstadual = dto.InscricaoEstadual,
                Logradouro = dto.Logradouro,
                Nome = dto.Nome,
                Numero = dto.Numero,
                Cidade = dto.Cidade,
                Telefone = dto.Telefone,
                Whatssap = dto.Whatssap
            };

            var validationResult = _clientesValidator.Validate(_cliente);

            if(!validationResult.IsValid)
            {
                string errorMessage = string.Join(Environment.NewLine, validationResult.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(errorMessage, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return _cliente.Create();
        }

        public List<ClientesDto> ReadAll()
        {
            _cliente = new Clientes();
            return _mapper.Map<List<ClientesDto>>(_cliente.ReadAll());
            //var listClientes = _cliente.ReadAll();

            //List<ClientesDto> listClientesDto = listClientes.Select(cliente => new ClientesDto()
            //{
            //   Id = cliente.Id,
            //   Bairro = cliente.Bairro,
            //   CnpjCpf = cliente.CnpjCpf,
            //   Email = cliente.Email,
            //   Estado = cliente.Estado,
            //   InscricaoEstadual = cliente.InscricaoEstadual,
            //   Logradouro = cliente.Logradouro,
            //   Nome = cliente.Nome,
            //   Numero = cliente.Numero,
            //   Cidade = cliente.Cidade,
            //   Telefone = cliente.Telefone, 
            //   Whatssap = cliente.Whatssap
            //}).ToList();

            //return listClientes.Select(cliente => new ClientesDto()
            //{
            //    Id = cliente.Id,
            //    Bairro = cliente.Bairro,
            //    CnpjCpf = cliente.CnpjCpf,
            //    Email = cliente.Email,
            //    Estado = cliente.Estado,
            //    InscricaoEstadual = cliente.InscricaoEstadual,
            //    Logradouro = cliente.Logradouro,
            //    Nome = cliente.Nome,
            //    Numero = cliente.Numero,
            //    Cidade = cliente.Cidade,
            //    Telefone = cliente.Telefone,
            //    Whatssap = cliente.Whatssap
            //}).ToList();
        }
    }
}
