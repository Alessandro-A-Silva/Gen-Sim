using AutoMapper;
using FluentValidation;
using Gen_Sim.Dto;
using Gen_Sim.Mapper;
using Gen_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Controller
{
    public class EnderecosController
    {   
        private Enderecos? _endereco;
        IMapper _mapper;
        public EnderecosController()
        {
            MapperConfiguration _mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            _mapper = _mapperConfiguration.CreateMapper();
        }
        public async Task<EnderecosDto> Search(EnderecosDto dto)
        {
            _endereco = _mapper.Map<Enderecos>(dto);
            return _mapper.Map<EnderecosDto>(await _endereco.Search());
        }
    }
}
