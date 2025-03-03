using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogađajUvod
{
    public class Osoba
    {
        //delegate
        public delegate void PromjenaPrezimenaDelegate(object sender, EventArgs e);

        //događaj
        public event PromjenaPrezimenaDelegate PromjenaPrezimena;

        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set {
                prezime = value;
                if (PromjenaPrezimena!=null)
                {
                    PromjenaPrezimena (this, new EventArgs()); 
                }
            }   
        }
    }
}
