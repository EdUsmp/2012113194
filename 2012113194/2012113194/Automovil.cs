using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012113194
{
    class Automovil : Carro
    {
        public TipoAuto _tipoauto;

        int _numLlantas;
		int _numAsientos;
		
        public Automovil(int numLlantas,int numAsientos)
        {
            _numLlantas = numLlantas;
			_numAsientos= numAsientos;
        }
		
		string Volante(string volante);
		string Parabrisas(string parabrisas);
		string Propietario(string propietario);
		string TipoCarro(string tipoCarro);
        public int Llantas { get { return _numLlantas; } }

       public int Asientos { get { return _numAsientos; } }

    }
}
