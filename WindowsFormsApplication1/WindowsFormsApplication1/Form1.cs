using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void logou() {
            lbl.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logou();
            try
            {
                if(Directory.Exists(@"C:\teste") == false)
                {
                    Directory.CreateDirectory(@"C:\teste");
                }
                

                //System.IO.File.WriteAllText(@"C:\teste\teste.txt", "Arquivo Teste");

                preencherLog("Usuário logou no sistema");

            }
            catch (Exception ex)
            {
                System.IO.File.WriteAllText("C:\teste\teste.txt", ex.Message.ToString());
            }
        }

        private void preencherLog(string Log)
        {
            using (StreamWriter writer = File.AppendText(@"C:\teste\teste.txt"))
            {
                writer.Write(Log + System.DateTime.Now.ToString());
                writer.Flush();
            }
        }
    }
}
