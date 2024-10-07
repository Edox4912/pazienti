using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pazienti_biglietto;

namespace pazienti
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();




            ListView list1 = LW_paziente1;
            ListView list2 = LW_paziente2;
            Console.WriteLine("Premere INVIO per terminare");
            Console.ReadLine();
        }

       
        private void btn_paziente1_Click(object sender, EventArgs e)
        {
            Pazienti paziente1 = new Pazienti();
            Thread p1 = new Thread(paziente1.Estrattore);
            p1.Start(LW_paziente1);
        }

        private void btn_paziente2_Click(object sender, EventArgs e)
        {
            Pazienti paziente2 = new Pazienti();
            Thread p2 = new Thread(paziente2.Estrattore);
            p2.Start(LW_paziente2);
        }
    }
}
