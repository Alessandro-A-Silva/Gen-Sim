using FluentValidation;
using Gen_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Validation
{
    public class ClientesValidator : AbstractValidator<Clientes>
    {
        public ClientesValidator() 
        {
            RuleFor(cliente => cliente.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .Length(2, 100).WithMessage("O nome deve ter entre 2 e 100 caracteres.");

            RuleFor(cliente => cliente.CnpjCpf)
                .NotEmpty().WithMessage("O documento de cnpj/cpf é obrigatório.")
                .Must(cnpjCpf => cnpjCpf.Length == 11 || cnpjCpf.Length == 14).WithMessage("O cnpj deve ter 14 caracteres e em caso de cpf deve ter 11 caracteres.")
                .Matches(@"^\d*$").WithMessage("O cnpj/cpf deve conter apenas números.");

            RuleFor(cliente => cliente.InscricaoEstadual)
                .Length(9).WithMessage("A inscrição estadual deve conter 9 caracteres.")
                .Matches(@"^\d*$").WithMessage("A inscrição estadual deve conter apenas números.")
                .When(cliente => !string.IsNullOrEmpty(cliente.InscricaoEstadual)); 

            RuleFor(cliente => cliente.Cep)
                .Length(8).WithMessage("O cep deve conter 8 caracteres.")
                .Matches(@"^\d*$").WithMessage("O cep deve conter apenas números.")
                .When(cliente => !string.IsNullOrEmpty(cliente.Cep));

            RuleFor(cliente => cliente.Logradouro)
                .MaximumLength(100).WithMessage("O logradouro deve ter no maximo 100 caraceres.");

            RuleFor(cliente => cliente.Bairro)
                .NotEmpty().WithMessage("O bairro é obrigatório.")
                .Length(2, 50).WithMessage("O bairro deve ter de 2 e 50 caracteres.");

            RuleFor(cliente => cliente.Estado)
                .NotEmpty().WithMessage("O estado é obrigatório.")
                .Length(4, 50).WithMessage("O estado deve ter de 4 a 50 caracteres.");

            RuleFor(cliente => cliente.Telefone)
                .Length(11).WithMessage("O telefone deve ter no maximo 11 caracteres.")
                .Matches(@"^\d*$").WithMessage("O telefone deve conter apenas números.")
                .When(cliente => !string.IsNullOrEmpty(cliente.Telefone));

            RuleFor(cliente => cliente.Whatssap)
                .NotEmpty().WithMessage("O whatssap é obrigatório.")
                .Length(11).WithMessage("O whatssap deve ter 11 caracteres.")
                .Matches(@"^\d*$").WithMessage("O telefone deve conter apenas números.");

            RuleFor(cliente => cliente.Numero)
                .Must(numero => numero >= 0).WithMessage("O número deve ser maior ou igual a 0.");

            RuleFor(cliente => cliente.Cidade)
                .NotEmpty().WithMessage("A cidade é obrigatória.")
                .Length(2, 50).WithMessage("A cidade de ter de 2 a 50 caracteres.");

            RuleFor(cliente => cliente.Email)
                .EmailAddress().WithMessage("O e-mail deve ser válido.")
                .When(cliente => !string.IsNullOrEmpty(cliente.Email));
        }
    }
}
