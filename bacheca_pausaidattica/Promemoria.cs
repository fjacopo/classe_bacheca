using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bacheca_pausaidattica
{
    public class Promemoria
    {
        string _p;
        string _data;

        public string P
        {
            get
            {
                return _p;
            }
            set
            {
                if (value != null)
                    _p= value;
                else
                    throw new Exception("Inserire un promemoria valido");
            }
        }

        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                if (value != null)
                    _data = value;
                else
                    throw new Exception("Inserire una data valida");
            }
        }
        public Promemoria(string p, string data)
        {
            P = p;
            Data = data;
            
        }


        public override string ToString()
        {
            return this.P + ";" + this.Data;
        }

        public bool Equals(Promemoria p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.Data == p.Data & this.P==p.P);
        }

        public Promemoria Clone()
        {
            return new Promemoria(this);
        }

        protected Promemoria(Promemoria other) : this(other.P, other.Data)
        {
        }

    }
}
