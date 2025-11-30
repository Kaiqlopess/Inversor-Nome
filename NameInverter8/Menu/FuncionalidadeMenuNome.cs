using NameInverter.CasoDeUso;
using NameInverter.CasoDeUso.Contratos.Nome;
using NameInverter.CasoDeUso.Contratos.Sobrenome;
using NameInverter.CasoDeUso.Serviços.Nome;
using NameInverter.CasoDeUso.Serviços.Sobrenome;
using NameInverter.Repositorio;
using NameInverter.Repositorio.RepositorioSobrenome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter
{
    public class FuncionalidadeMenuNome
    { 

        public void menu(string escolha)
        {
            var repositorioNome = new RepositoryNome();
            var repositorioSobrenome = new RepositorySobrenome();

            switch (escolha)
            {
                case "1":
                    InserirNomeCompleto nomeAdicionado = new InserirNomeCompleto();
                    nomeAdicionado.Inserir();
                    break;
                case "2":
                    AtualizarNomeCompleto nomeAtualizado = new AtualizarNomeCompleto();
                    nomeAtualizado.Atualizar();
                    break;
                case "3":
                    DeletarNomeCompleto nomeDeletado = new DeletarNomeCompleto(repositorioNome);
                    nomeDeletado.Deletar();
                    break;
                case "4":
                    ListarNomeCompleto listarNomeCompleto = new ListarNomeCompleto();
                    listarNomeCompleto.listar();
                    break;
                default:
                    Console.WriteLine("Opçao nao existe!");
                    Console.WriteLine("aperte ENTER!");
                    Console.ReadLine();
                    return;
            }
        }  
    }
}
