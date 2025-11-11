using Microsoft.EntityFrameworkCore;
using NameInverter.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class Repository : IRepository
    {
        private readonly MeuContexto _repositorio;
       

        public Repository() 
        {
            this._repositorio = new MeuContexto();
        }

    

        public void Add(string nome) 
        {
            Name name = new CommonName(nome);

            _repositorio.Nomes.Add((CommonName)name);
            _repositorio.SaveChanges();
        }

        public void ToList() 
        {
            List<CommonName> nomes =_repositorio.Nomes.ToList();

            foreach (var nome in nomes)
            {
                Console.WriteLine($"ID({nome.Id})/Nome: {nome.name}");
            }
        }

        public bool DadosIguais(string nome) 
        {
            if (_repositorio.Nomes.FirstOrDefault(p => p.name == nome) != null)
            {
                return true;
            }
            return false;
        }

        public Name Procurar(string Nome)
        {

            Name nomeAchado = _repositorio.Nomes.FirstOrDefault(p => p.name == Nome);

            if (nomeAchado != null) {
                return nomeAchado;
            }
            return null;
        }

        public void Remove(CommonName nome)
        {
            _repositorio.Nomes.Remove(nome);
            _repositorio.SaveChanges();
        }

        public void Atualizar(CommonName nome) {
            _repositorio.Nomes.Update(nome);
            _repositorio.SaveChanges();
        }


    }
}
