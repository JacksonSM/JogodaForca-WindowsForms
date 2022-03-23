using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Jogo_da_Forca.Entities
{
    public class PalavraSecreta
    {
        public string _PalavraSecreta { get; set; }
        public char[] _PalavraSecretaTela { get; set; }

        

        public int NumeroLetras { get; set; }
        public string Dica { get; set; }


        private Label lblDica;
        public FlowLayoutPanel Flow;

        public PalavraSecreta(string palavraSecreta,string dica,FlowLayoutPanel flow,Label label)
        {
            lblDica = label;
            Flow = flow;
        
           

            Iniciar(palavraSecreta,dica);

        }


        public void Iniciar( string palavraSecreta,string dica)
        {
            Dica = dica;
            _PalavraSecreta = palavraSecreta;
            NumeroLetras = _PalavraSecreta.Length;
            _PalavraSecretaTela = _PalavraSecreta.ToCharArray();

            lblDica.Text = "Dica: "+ Dica;

            for (int i = 0; i < NumeroLetras; i++)
            {
                string name = "lblLetra" + i;
                Flow.Controls.Add(new Label { Name = name, Text = "_", Font = new System.Drawing.Font("Arial", 25, System.Drawing.FontStyle.Bold), AutoSize = true });

            }
           
        }
        public Boolean LetraDigitada(char letra)
        {
            bool letraExiste = false; 
            for (int i = 0; i < NumeroLetras; i++)
            {
                if (_PalavraSecretaTela[i] == letra)
                {
                    string l = "lblLetra" + i;                 
                    RevelarLetra(l, letra);
                    letraExiste = true;
                }       
                
            }
            return letraExiste;

        }
        private void RevelarLetra(string lbl, char letra)
        {
          
            foreach (Label obj in Flow.Controls)
            {
                if (obj.Name == lbl)
                {
                    obj.Text = letra.ToString();
                    
                }
                
            }

            
        }
        public void MudarPalavra(string palavraSecreta,string dica)
        {
            Flow.Controls.Clear();
            Iniciar(palavraSecreta, dica);
        }
       
    }
}
