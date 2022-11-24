using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S7.Net_Windows_Form
{
    public partial class Form1 : Form
    {
        private Plc plc = null;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnBaglantiKur_Click(object sender, EventArgs e)
        {
            CpuType cpu = (CpuType)Enum.Parse(typeof(CpuType), cmbCpuType.SelectedValue.ToString());
            plc = new Plc(cpu, txtIpAdres.Text, rack: Convert.ToInt16(txtRack.Text), slot: Convert.ToInt16(txtSlot.Text)); //değerleri convert yapmamızın sebebi değerlerin short istenmesi.
            plc.Open();
            if(plc.IsConnected)
            {
                txtBaglanti.Text = "Bağlantı Sağlandı";
            }
        }

        private void btnBaglantıKes_Click(object sender, EventArgs e)
        {
            plc.Close();
            txtBaglanti.Text = "Bağlantı Kesildi";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCpuType.DataSource = Enum.GetNames(typeof(CpuType)); //Datasource comboboxta seçenek sunmak için kullanıldı.
        }

        private void btnVeriOku_Click(object sender, EventArgs e)
        {
            string adres = txtPlcHafiza.Text;
            object okunanDeger = plc.Read(adres);
            txtOkunanDeger.Text = string.Format("{0}", okunanDeger.ToString());
        }

        private void btnVeriYaz_Click(object sender, EventArgs e)
        {
            string adres = txtPlcHafiza.Text;
            object yazilanDeger = txtYazilanDeger.Text;
            plc.Write(adres, yazilanDeger);
        }
    }
}
