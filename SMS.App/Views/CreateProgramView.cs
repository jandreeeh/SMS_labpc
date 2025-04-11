using Microsoft.EntityFrameworkCore;
using SMS.App.Views.IViews;
using SMS.Domain;
using SMS.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.App.Views
{
    public partial class CreateProgramView : Form
    {
        private AppDbContext _dbContext;
        public CreateProgramView()
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {
            var program = new Programs
            {
                ProgramName = textBoxProgramName.Text,
                Description = textBoxDescription.Text
            };
            await _dbContext.Programs.AddAsync(program);
            await _dbContext.SaveChangesAsync();

            MessageBox.Show("Program Created Successfully");

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
