﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEndereco
{
    public class Empresa
    {
        public string razaoSocial;
        public string cnpj;
        public Endereco endereco = new Endereco();
    }
}
