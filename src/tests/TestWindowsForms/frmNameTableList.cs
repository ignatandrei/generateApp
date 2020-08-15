using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TestWEBAPI_DAL;

namespace TestWindowsForms
{
    public partial class frmNameTableList : Form
    {
        public frmNameTableList()
        {
            InitializeComponent();
        }

        private async void frmNameTableList_Load(object sender, EventArgs e)
        {
            var builder = new DbContextOptionsBuilder<DatabaseContext>();
            builder.UseInMemoryDatabase("andrei");
            var opt = builder.Options;
            var db = new DatabaseContext(opt);
            db.Database.EnsureCreated();
            var data = new SheetData_Repository(db);

            dataGridView1.DataSource = await data.GetAll();

        }
    }
}
