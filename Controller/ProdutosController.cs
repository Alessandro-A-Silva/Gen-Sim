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
    public class ProdutosController
    {
        private Produtos? _produtos;
        private readonly IValidator<Produtos> _produtosValidator;
        IMapper _mapper;
        public ProdutosController()
        {
            _produtosValidator = new ProdutosValidator();
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = mapperConfiguration.CreateMapper();
        }

        public bool Create(ProdutosDto dto)
        {
            _produtos = _mapper.Map<Produtos>(dto);
            var validationResult = _produtosValidator.Validate(_produtos);
            if (!validationResult.IsValid)
            {
                string errorMessage = string.Join(Environment.NewLine, validationResult.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(errorMessage, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return _produtos.Create();
        }

        public bool Update(ProdutosDto dto) 
        {
            _produtos = _mapper.Map<Produtos>(dto);
            var validationResult = _produtosValidator.Validate(_produtos);
            if (!validationResult.IsValid)
            {
                string errorMessage = string.Join(Environment.NewLine, validationResult.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(errorMessage, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return _produtos.Update();
        }

        public List<ProdutosDto> ReadAll()
        {
            _produtos = new Produtos();
            return _mapper.Map<List<ProdutosDto>>(_produtos.ReadAll());
        }

        public bool UpdateEstoque(ProdutosDto dto)
        {
            _produtos = _mapper.Map<Produtos>(dto);
            var validationResult = _produtosValidator.Validate(_produtos);
            if (!validationResult.IsValid)
            {
                string errorMessage = string.Join(Environment.NewLine, validationResult.Errors.Select(error => error.ErrorMessage));
                MessageBox.Show(errorMessage, "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return _produtos.Update();
        }

        public bool Delete(ProdutosDto dto)
        {
            _produtos = _mapper.Map<Produtos>(dto);
            return _produtos.Delete();
        }
    }
}
