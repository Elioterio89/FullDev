using EstudoFull.Models;
using EstudoFull.Services.Interfaces;

namespace EstudoFull.Services
{
    public class PessoaService : IPessoaService
    {
        public Pessoa Atualizar(Pessoa pPessoa)
        {
            return pPessoa;
        }

        public Pessoa BuscarPorId(long pId)
        {
            return new Pessoa
            {
                Id = 1,
                Endereco = "Morro do gato",
                Genero = "Feminino",
                PrimeiroNome = "Tania",
                Sobrenome = "Lima"
            };
        }

        public Pessoa BuscarPorNome(string pNome)
        {
            return new Pessoa
            {
                Id = 2,
                Endereco = "Simoes Filho",
                Genero = "Feminino",
                PrimeiroNome = "Eliene",
                Sobrenome = "Soares"
            };
        }

        public Pessoa Criar(Pessoa pPessoa)
        {
            return pPessoa;
        }

        public bool Deletar(long pId)
        {
            return true;
        }

        public List<Pessoa> Listar()
        {
            List<Pessoa> lPessoas = new List<Pessoa>();
            for (int i=0;i<5;i++)
            {
                Pessoa oPessoa = MockPessoa(i);
                lPessoas.Add(oPessoa);
            }
            return lPessoas;
        }

        private Pessoa MockPessoa(int pIndex)
        {
            List<Pessoa> lPessoas = new List<Pessoa>
            {
                new Pessoa
                {
                    Id = 1,
                    Endereco = "Morro do gato",
                    Genero = "Feminino",
                    PrimeiroNome = "Tania",
                    Sobrenome = "Lima"
                },
                new Pessoa
                {
                    Id = 2,
                    Endereco = "Simoes Filho",
                    Genero = "Feminino",
                    PrimeiroNome = "Eliene",
                    Sobrenome = "Soares"
                },
                new Pessoa
                {
                    Id = 3,
                    Endereco = "Mais um endereço",
                    Genero = "Feminino",
                    PrimeiroNome = "Ana",
                    Sobrenome = "Santos"
                },
                new Pessoa
                {
                    Id = 4,
                    Endereco = "Endereço diferente",
                    Genero = "Masculino",
                    PrimeiroNome = "João",
                    Sobrenome = "Pereira"
                }

            };

            return lPessoas.Where(x => x.Id == pIndex).FirstOrDefault();
        }
    }
}
