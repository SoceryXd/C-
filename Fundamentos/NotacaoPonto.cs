﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {

        public static void Executar() {

            string saudacao = "Olá".ToUpper().Insert(3, " World!").Replace("World", "Mundo");

            Console.WriteLine(saudacao);
        }

    }
}
