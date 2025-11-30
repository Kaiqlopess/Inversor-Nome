using NameInverter.Nome.NomeConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.Repositorio.RepositorioSobrenome
{
    public class RepositorySobrenome : IRepositorySobrenome
    {
        private readonly MeuContexto _repositorio;

        public RepositorySobrenome() 
        {
            _repositorio = new MeuContexto();
        }

        public void Add(SobrenomeName nome)
        {
            try
            {
                _repositorio.Sobrenomes.Add(nome);
                _repositorio.SaveChanges();
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Erro ao inserir o Sobrenome: {ex.Message}");

            }
        }

        public bool DadosIguais(string nome)
        {
            if (_repositorio.Sobrenomes.FirstOrDefault(p => p.name == nome) != null)
            {
                return true;
            }
            return false;
        }

        public Name Procurar(Guid IdNome)
        {
            var nomeAchado = _repositorio.Sobrenomes.FirstOrDefault(p => p.CommonNameId == IdNome);

            if (nomeAchado != null)
            {
                return nomeAchado;
            }

            return null;
        }

        public void Remove(SobrenomeName nome)
        {
            try
            {
                _repositorio.Sobrenomes.Remove(nome);
                _repositorio.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover o Sobrenome: {ex.Message}");
            }
        }

        public void ToList()
        {
            List<SobrenomeName> sobrenomes = _repositorio.Sobrenomes.ToList();

            foreach (var sobrenome in sobrenomes)
            {
                Console.WriteLine($"ID({sobrenome.Id})/Nome: {sobrenome.name}");
            }
        }

        public void Update(SobrenomeName nome)
        {
            try
            {
                _repositorio.Sobrenomes.Update(nome);
                _repositorio.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao Atualizar o Sobrenome: {ex.Message}");
            }
        }
    }
}
