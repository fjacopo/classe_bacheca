using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bacheca_pausaidattica
{
    public class Bacheca
    {
       string _nome;
        string _descrizione;
        string _proprietario;
        private Promemoria[] _p ;


        public Bacheca(string nome, string descrizione, string proprietario)
        {
           Nome= nome;
           Descrizione= descrizione;
           Proprietario= proprietario;
           _p = new Promemoria[999];

        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            private set
            {
                if (value != null)
                    _nome = value;
                else
                    throw new Exception("Inserire un nome valido");
            }
        }
        public string Descrizione
        {
            get
            {
                return _descrizione;
            }
            private set
            {
                if (value != null)
                    _descrizione = value;
                else
                    throw new Exception("Inserire una descrizione valida");
            }
        }
        public string Proprietario
        {
            get
            {
                return _proprietario;
            }
            private set
            {
                if (value != null)
                    _proprietario = value;
                else
                    throw new Exception("Inserire un proprietario valido");
            }
        }
        
        
        private int getNumPromemoria()
        {
            int i = 0;
            while (i < _p.Length && _p[i] != null)
            {
                i++;
            }

            if (i != _p.Length)
                return i;
            else
                throw new Exception("Hai finito lo spazio per i promemoria nella bacheca");
        }

        public void Aggiungi(Promemoria p)
        {
            if (p != null)
                _p[getNumPromemoria()] = p;
            else
                throw new Exception("Inserire un promemoria valido");
        }
        public Promemoria getPromemoria(int i)
        {
            return _p[i];
        }
        public Promemoria Rimuovi(Promemoria p)
        {
            int pos = Cerca(p);
            if (pos != -1)
            {
                _p[pos] = null;
                for (int i = pos; i < 99; i++)
                {
                    _p[i] = _p[i + 1];
                }
                return p;
            }
            else
                throw new Exception("Promemoria non esistente!");
        }
        public int Cerca(Promemoria p)
        {
            int pos = -1;
            for (int i = 0; i < 999; i++)
            {
                if (_p[i] == p)
                {
                    pos = i;
                }
            }
            return pos;
        }
        public string[] getPromemoriaConParola(string parola, string[] inputArray) //inputArray --> array dei promemoria
        {
            // Creiamo una array per contenere le stringhe trovate
            string[] stessaparola = new string[999];
            int c = 0;
            // Scorriamo l'array di input
            for (int i = 0; i < inputArray.Length; i++)
            {
                // Se la stringa contiene la parola chiave, aggiungila alla lista
                if (inputArray[i].Contains(parola))
                {
                    stessaparola[c] = inputArray[i];
                    c++;
                }
            }
            return stessaparola;
        }
        public void AggiungiConData(Promemoria p)
        {
            string dataOggi = DateTime.Now.ToString("dd/MM/yyyy"); 
            if (p != null)
            {
                p.Data = dataOggi;
                _p[getNumPromemoria()] = p;
            }
            else { 
                throw new Exception("Inserire un promemoria valido");
                
                
            }
               
        }
        public Promemoria RimuoviConData(Promemoria p)
        {
            int pos = Cerca(p);
            if (pos != -1)
            {
                _p[pos] = null;
                for (int i = pos; i < 99; i++)
                {
                    _p[i] = _p[i + 1];
                }
                return p;
            }
            else
                throw new Exception("Promemoria non esistente!");
        }

        public string[] getPromemoriaConData(string data, string[] inputArray)
        {
            string[] stessadata = new string[999];
            int c = 0;
            // Scorriamo l'array di input
            for (int i = 0; i < inputArray.Length; i++)
            {
                // Se la stringa contiene la parola chiave, aggiungila alla lista
                if (inputArray[i].Contains(data))
                {
                    stessadata[c] = inputArray[i];
                    c++;
                }
            }
            return stessadata;

        }

        public void Sposta(Bacheca destinazione, Promemoria p)
        {
            this.Rimuovi(p);
            destinazione.Aggiungi(p);

        }
        public void SpostaConData(Bacheca destinazione, Promemoria p)
        {
            this.RimuoviConData(p);
            destinazione.AggiungiConData(p);
        }



        public override string ToString()
        {
            return this.Nome + ";" + this.Descrizione + ";" + this.Proprietario;
        }

        public bool Equals(Bacheca b)
        {
            if (b == null) return false;

            if (this == b) return true;

            return (this.Proprietario == b.Proprietario & this.Nome==b.Nome);
        }

        public Bacheca Clone()
        {
            return new Bacheca(this);
        }

        protected Bacheca(Bacheca other) : this(other.Nome, other.Descrizione, other.Proprietario)
        {
        }

    }
            


}

   

