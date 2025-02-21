using FluentValidation;
using Gen_Sim.Dto;
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
        private Clientes _cliente;
        private readonly IValidator<Clientes> _clientesValidator;
        public ClientesController() => _clientesValidator = new ClientesValidator();
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
    }
}
