using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogodeJogos.Execeptions
{
    public class JogoJaCadastradoExeception : Exception
    {
        public JogoJaCadastradoExeception()
            : base("Este já jogo está cadastrado")
        { }
    }
}
