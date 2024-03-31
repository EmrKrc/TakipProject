using EntityProject.DAL;
using EntityProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProject
{
    public partial class frmKatmanliMimari : Form
    {
        public frmKatmanliMimari()
        {
            InitializeComponent();
        }
        viewPersonelBirimDAL vpbdal=new viewPersonelBirimDAL();
        BirimDAL bdal=new BirimDAL();
        Personeller p=new Personeller();
        PersonelDAL pdal = new PersonelDAL();
        private void FrmKatmanliMimari_Load(object sender, EventArgs e)
        {
            Yenile();
            Data_Binding(new Personeller());
        }
        void ClearDataBinding()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }
        void Data_Binding(Personeller person)
        {
            ClearDataBinding();
            this.p = person;
            txtPersonelID.DataBindings.Add("Text", p, "PersonelID");
            txtAdiSoyadi.DataBindings.Add("Text", p, "AdiSoyadi");
            txtTelefon.DataBindings.Add("Text", p, "Telefon");
            txtAdres.DataBindings.Add("Text", p, "Adres");
            txtEmail.DataBindings.Add("Text", p, "Email");
            cmbBirim.DataBindings.Add("SelectedValue", p, "BirimID",true);
            dateTimePicker1.DataBindings.Add("Text", p, "Tarih", true);
            chckIsActive.DataBindings.Add("CheckState", p, "IsActive",true);
        }

        public void Yenile()
        {
            dataGridView1.DataSource= vpbdal.GetList();
            cmbBirim.DataSource = bdal.GetList();
        }
 
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vpbdal.GetList(x=>x.AdiSoyadi.Contains(txtAra.Text));
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int personelid = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
            Data_Binding(pdal.GetByFilter(x => x.PersonelID==personelid));
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Data_Binding(new Personeller());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            pdal.AddorUpdate(p);
            pdal.Save();
            Yenile();
            Data_Binding(new Personeller());
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            int personelid = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
            pdal.Delete(p => p.PersonelID == personelid);
            pdal.Save();
            Yenile();
            Data_Binding(new Personeller());
        }
    }
}
