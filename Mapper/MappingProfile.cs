﻿using AutoMapper;
using Gen_Sim.Dto;
using Gen_Sim.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Sim.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            #region Clientes
            CreateMap<Clientes, ClientesDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.CnpjCpf, opt => opt.MapFrom(src => src.CnpjCpf))
                .ForMember(dest => dest.InscricaoEstadual, opt => opt.MapFrom(src => src.InscricaoEstadual))
                .ForMember(dest => dest.Cep, opt => opt.MapFrom(src => src.Cep))
                .ForMember(dest => dest.Logradouro, opt => opt.MapFrom(src => src.Logradouro))
                .ForMember(dest => dest.Bairro, opt => opt.MapFrom(src => src.Bairro))
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Numero))
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Whatssap, opt => opt.MapFrom(src => src.Whatssap))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Cidade, opt => opt.MapFrom(src => src.Cidade));

            CreateMap<ClientesDto, Clientes>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.CnpjCpf, opt => opt.MapFrom(src => src.CnpjCpf))
                .ForMember(dest => dest.InscricaoEstadual, opt => opt.MapFrom(src => src.InscricaoEstadual))
                .ForMember(dest => dest.Cep, opt => opt.MapFrom(src => src.Cep))
                .ForMember(dest => dest.Logradouro, opt => opt.MapFrom(src => src.Logradouro))
                .ForMember(dest => dest.Bairro, opt => opt.MapFrom(src => src.Bairro))
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Numero))
                .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Whatssap, opt => opt.MapFrom(src => src.Whatssap))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Cidade, opt => opt.MapFrom(src => src.Cidade));
            #endregion

            #region Enderecos
            CreateMap<Enderecos, EnderecosDto>()
                .ForMember(dest => dest.cep, opt => opt.MapFrom(src => src.cep))
                .ForMember(dest => dest.logradouro, opt => opt.MapFrom(src => src.logradouro))
                .ForMember(dest => dest.bairro, opt => opt.MapFrom(src => src.bairro))
                .ForMember(dest => dest.localidade, opt => opt.MapFrom(src => src.localidade))
                .ForMember(dest => dest.estado, opt => opt.MapFrom(src => src.estado));

            CreateMap<EnderecosDto, Enderecos>()
                .ForMember(dest => dest.cep, opt => opt.MapFrom(src => src.cep))
                .ForMember(dest => dest.logradouro, opt => opt.MapFrom(src => src.logradouro))
                .ForMember(dest => dest.bairro, opt => opt.MapFrom(src => src.bairro))
                .ForMember(dest => dest.localidade, opt => opt.MapFrom(src => src.localidade))
                .ForMember(dest => dest.estado, opt => opt.MapFrom(src => src.estado));
            #endregion

            #region Produtos
            CreateMap<Produtos, ProdutosDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao))
                .ForMember(dest => dest.Preco, opt => opt.MapFrom(src => src.Preco))
                .ForMember(dest => dest.Estoque, opt => opt.MapFrom(src => src.Estoque));

            CreateMap<ProdutosDto, Produtos>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao))
                .ForMember(dest => dest.Preco, opt => opt.MapFrom(src => src.Preco))
                .ForMember(dest => dest.Estoque, opt => opt.MapFrom(src => src.Estoque));
            #endregion
        }

    }
}
