﻿using Prototipo1.View;
using System;
using System.Windows.Forms;

namespace Prototipo1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.ddd
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pagina_Principal());
        }
    }
}
