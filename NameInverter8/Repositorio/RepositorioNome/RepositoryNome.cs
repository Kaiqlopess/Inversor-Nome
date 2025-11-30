using Microsoft.EntityFrameworkCore;
using NameInverter.Nome.NomeConcreto;
using NameInverter.Repositorio.RepositorioNome;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NameInverter.Repositorio
{
    public class RepositoryNome : IRepositoryNome
    {
        private readonly MeuContexto _repositorio;
       

        public RepositoryNome() 
        {
            this._repositorio = new MeuContexto();
        }

    

        public void Add(CommonName nome) 
        {
            try
            {
                _repositorio.Nomes.Add(nome);
                _repositorio.SaveChanges();
            }
            catch (Exception ex) {
                Console.WriteLine($"Erro ao inserir o Nome: {ex.Message}");
            }     
        }


        public List<CommonName> ToList() 
        {
            List<CommonName> nomes =_repositorio.Nomes.ToList();

            return nomes;
        }

        public List<CommonName> TolistNameComplete()
        {
            List<CommonName> list = _repositorio.Nomes.Include(n => n.Sobrenome).ToList();

            return list;

        }

        public bool DadosIguais(string nome) 
        {
            if (_repositorio.Nomes.FirstOrDefault(p => p.name == nome) != null)
            {
                return true;
            }
            return false;
        }

        public Name Procurar(Guid Nome)
        {

            Name nomeAchado = _repositorio.Nomes.FirstOrDefault(p => p.Id == Nome);

            if (nomeAchado != null) {
                return nomeAchado;
            }

            return null;
        }

        public void Remove(CommonName nome)
        {
            try
            {
                _repositorio.Nomes.Remove(nome);
                _repositorio.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover o Nome: {ex.Message}");
            }
        }

        public void Update(CommonName nome) {

            try
            {
                _repositorio.Nomes.Update(nome);
                _repositorio.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao Atualizar o Nome: {ex.Message}");
            }
        }
    }
}
