using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace insert_csharp
{
    public class Funcionario
    {
        public int idFuncionario { get; set; }
        public int idPessoa { get; set; }
        public string cargo { get; set; }
        public double salario { get; set; }
        public int ramal { get; set; }

        /*
    idFuncionario int primary key identity(1,1),
	idPessoa int,
	cargo varchar(100),
	salario decimal(5,2),
	ramal int,
         */
    }
}
