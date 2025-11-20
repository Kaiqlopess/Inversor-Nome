using Microsoft.EntityFrameworkCore;
using NameInverter.Nome.NomeConcreto;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NameInverter.Repositorio
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
            string[] words = nome.Split(' ');

            Name name = new CommonName(words[0]);

            Name sobrenome = new Sobrenome(words[1]);

            sobrenome.Id = name.Id;

            try
            {
                _repositorio.Nomes.Add((CommonName)name);
                _repositorio.Sobrenomes.Add((Sobrenome)sobrenome);
                _repositorio.SaveChanges();
            }
            catch (Exception ex) {
                Console.WriteLine($"Erro ao inserir o Nome: {ex.Message}");
            }
            
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
