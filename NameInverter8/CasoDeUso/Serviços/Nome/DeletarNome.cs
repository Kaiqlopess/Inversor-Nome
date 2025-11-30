using NameInverter.CasoDeUso.Contratos.Nome;
using NameInverter.CasoDeUso.Contratos.Sobrenome;
using NameInverter.CasoDeUso.Serviços.Sobrenome;
using NameInverter.Menu;
using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioNome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso.Serviços.Nome
{
    public class DeletarNome : IDeletarNome
    {
        private IRepositoryNome _repositorioNome = new RepositoryNome();
   
        public void Deletar(Guid IdDeletar) {

            Name nomeDeletar = _repositorioNome.Procurar(IdDeletar);

            if (nomeDeletar == null)
            {
                Console.WriteLine("ERRO AO DIGITAR O Id do NOME!");
                Console.ReadLine();
                return;
            }

            _repositorioNome.Remove((CommonName)nomeDeletar);
        }

    }
}

