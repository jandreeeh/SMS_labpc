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
        private Programs? _editProgram;

        public CreateProgramView(Programs? editProgram = null)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            _editProgram = editProgram;

            if(_editProgram != null)
            {
                textBoxProgramName.Text = _editProgram.ProgramName;
                textBoxDescription.Text = _editProgram.Description;
            }
        }

        private async void buttonCreate_Click(object sender, EventArgs e)
        {

            if(_editProgram == null)
            {
                _editProgram = new Programs
                {
                    ProgramName = textBoxProgramName.Text,
                    Description = textBoxDescription.Text
                };
                await _dbContext.Programs.AddAsync(_editProgram);

                MessageBox.Show("Program Created Successfully");
            }
            else
            {
                _editProgram.ProgramName = textBoxProgramName.Text;
                _editProgram.Description = textBoxDescription.Text;
                _dbContext.Programs.Update(_editProgram);

                MessageBox.Show("Program Updated Successfully");
            }

                await _dbContext.SaveChangesAsync();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
