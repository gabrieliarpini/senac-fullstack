using System.Text.RegularExpressions;

namespace MeuCorre.Domain.Entities
{
    public class Tag : Entidade
    {
        public Guid UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Cor { get; private set; }

        private void ValidarEntidadeTag(string cor)
        {
            if (string.IsNullOrEmpty(cor))
            {
                return; //retorna caso a cor seja nula ou vazia
            }

            //#FF02AB
            var corRegex = new Regex(@"^#?([0-9a-fA-F]{3}){1,2}$");

            if (!corRegex.IsMatch(cor))
            {
                throw new Exception("A cor deve estar no formato hexadecimal");
            }
        }

        public Tag(Guid usuarioId, string nome,  string cor)
        {
         
            UsuarioId = usuarioId;
            Nome = nome.ToLower();
            Cor = cor;
        }


    }
} 