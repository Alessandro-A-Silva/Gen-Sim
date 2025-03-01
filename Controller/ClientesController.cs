﻿using AutoMapper;
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
            _cliente = _mapper.Map<Clientes>(dto);
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
        }

        public bool Update(ClientesDto dto)
        {
            _cliente = _mapper.Map<Clientes>(dto);
            var validationResult = _clientesValidator.Validate(_cliente);
            if(!validationResult.IsValid)
            {
                string errorMessage = string.Join(Environment.NewLine, validationResult.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(errorMessage, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return _cliente.Update();
        }

        public bool Delete(ClientesDto dto)
        {
            _cliente = _mapper.Map<Clientes>(dto);
            return _cliente.Delete();
        }
    }
}
