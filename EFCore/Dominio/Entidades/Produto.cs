﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
    }
}
