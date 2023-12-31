﻿using PrecisoPRO.Models;

namespace PrecisoPRO.Interfaces
{
    public interface IEmpresaRepository
    {
        Task<IEnumerable<Empresa>> GetAll();

        Task<Empresa> GetByIdAsync(int id);

        Task<Empresa> GetByIdAsyncNoTracking(int id);

        Task<IEnumerable<Empresa>> GetClubByCity(string cidade);


        bool Adicionar(Empresa empresa);


        bool Update(Empresa empresa);

        bool Delete(Empresa empresa);
        bool Save();
        
    }
}
