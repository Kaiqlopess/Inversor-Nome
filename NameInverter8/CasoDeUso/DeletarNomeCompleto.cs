using NameInverter.CasoDeUso.Contratos.Nome;
using NameInverter.CasoDeUso.Contratos.Sobrenome;
using NameInverter.CasoDeUso.Serviços.Nome;
using NameInverter.CasoDeUso.Serviços.Sobrenome;
using NameInverter.Menu;
using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioNome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.CasoDeUso
{
    public class DeletarNomeCompleto
    {
        private ListarNomeCompleto listarNomeCompleto = new ListarNomeCompleto();
        private IRepositoryNome _repositorio = new RepositoryNome();
        private IMenuExibirOperacao _menuExibirOperacao = new MenuExibirOperacao();
        private DeletarSobrenome _deletarSobrenome = new DeletarSobrenome();
        private DeletarNome _deletarNome = new DeletarNome();
        private RepositoryNome repositorioNome;

        public DeletarNomeCompleto(RepositoryNome repositorioNome)
        {
            this.repositorioNome = repositorioNome;
        }

        public void Deletar()
        {
            listarNomeCompleto.listar();

            _menuExibirOperacao.MenuDeletar();

            Guid idDeletar;

            try
            {
                idDeletar = Guid.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor digitado não é um Guid válido.");
                return;
            }

            _deletarSobrenome.Deletar(idDeletar);

            _deletarNome.Deletar(idDeletar);
            
            

        }


    }
}
