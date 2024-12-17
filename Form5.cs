using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeHazırlık1
{
    public partial class FormKaydet : Form
    {
        int? id;
        public bool Kaydedildi = false;
        public FormKaydet(int? Id = null)
        {
            InitializeComponent();
            if (Id != null)
            {
                this.id = Id;
            }
        }

        private void FormKaydet_Load(object sender, EventArgs e)
        {

        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            if (id == null)
            {
                if (radioButtonGelir.Checked == true)
                {

                    string sql = "Insert into Statistics(Type, Catogory, Month ,Amount) Values('" + radioButtonGelir.Text + "','" + comboBoxGelir.Text + "','" + comboBoxAy.Text + "','" + textBoxIslemler.Text + "')";
                    if (CRUD.ESD(sql))
                    {
                        Kaydedildi = true;
                        MessageBox.Show("Gelir ekleme işlemi gerçekleşti.");
                    }
                }
                else
                {
                    string sql = "Insert into Statistics(Type, Catogory, Month ,Amount) Values('" + radioButtonGider.Text + "','" + comboBoxGider.Text + "','" + comboBoxAy.Text + "','" + textBoxIslemler.Text + "')";
                    if (CRUD.ESD(sql))
                    {
                        Kaydedildi = true;
                        MessageBox.Show("Gider ekleme işlemi gerçekleşti.");
                        this.Close();

                    }
                }
            }
            else
            {
                string sql = "Update Statistics set Type='" + radioButtonGelir.Text + "',Catogory=" + comboBoxGelir.Text + "',Month='" + comboBoxAy.Text + "',Amount='" + textBoxIslemler.Text + "'  Where CatogoryId='"+id+"'";
                if (CRUD.ESD(sql))
                {
                    Kaydedildi = true;
                    MessageBox.Show("Güncelleme işlemi gerçekleşti.");
                    this.Close();
                }
            }
        }
    }
}
