using System;
using System.Collections.Generic;
using System.Text;


namespace App_custo_viagem_com_SQLITE.Model
{
    public class Pedagio
    {
        string _Localizacao;
        double _valor;

        public string localizacao
        {
            get => _Localizacao;
            set
            {
                if (value == null)
                    throw new Exception("Informe a localização");
                
                _Localizacao = value;
            }
        }

        public double valor
        {
            get => _valor;
            set
            {
                if (value == 0)
                    throw new Exception("Informe o Valor");

                _valor = value;
            }
        }
    }
}
