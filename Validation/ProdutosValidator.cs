using FluentValidation;
using Gen_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Validation
{
    public class ProdutosValidator : AbstractValidator<Produtos>
    {
        public ProdutosValidator() 
        {
            #region atributos
            RuleFor(produto => produto.Nome)
                .NotEmpty().WithMessage("O nome é obrigatório.")
                .Length(2, 100).WithMessage("O Nome deve ter entre 2 e 100 caracteres.");

            RuleFor(produto => produto.Descricao)
                .Length(0,100).WithMessage("O tamanho máximo da descrição é de 100 caracteres");

            RuleFor(produto => produto.Preco)
                .Must(preco => preco >= 0).WithMessage("O preço do produto deve ter valor positivo.");

            RuleFor(produto => produto.Estoque)
                .Must(estoque => estoque >= 0).WithMessage("Não é permitido saldo negativo de produto.");
            #endregion
        }

    }
}
