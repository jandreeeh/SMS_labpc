using Microsoft.EntityFrameworkCore;
using SMS.App.Views;
using SMS.App.Views.IViews;
using SMS.Domain;
using SMS.Infastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.App.Presenters
{
    public class ProgramPresenter
    {
        private IProgramView _programView;
        private AppDbContext _dbContext;
        private IEnumerable<Programs> _programList;
        private BindingSource _bindingSource;

        public ProgramPresenter(IProgramView programView)
        {
            _programView = programView;
            _dbContext = new AppDbContext();
            _bindingSource = new BindingSource();

            _programView.CreateEvent += CreateEvent;
            _programView.ReadEvent += ReadEvent;
            _programView.UpdateEvent += UpdateEvent;
            _programView.DeleteEvent += DeleteEvent;
            _programView.GetInfoEvent += GetInfoEvent;

            LoadProgramList();
            _programView.GetProgramList(_bindingSource);
        }

        private void GetInfoEvent(object? sender, EventArgs e)
        {
            var entity = (Programs)_bindingSource.Current;

            _programView.ProgramId = entity.ProgramId;
            _programView.ProgramName = entity.ProgramName;
            _programView.Description = entity.Description;
        }

        private void LoadProgramList(string? search = null)
        {
            _programList = _dbContext.Programs.ToList();

            if (search != null)
            {
                _programList = _programList
                    .Where(c => c.ProgramId.ToString()
                    .Contains(search) || c.ProgramName.Contains(search)).ToList();
            }

            _bindingSource.DataSource = _programList;
        }

        private void DeleteEvent(object? sender, EventArgs e)
        {
            var entity = (Programs)_bindingSource.Current;
            _dbContext.Programs.Remove(entity);
            _dbContext.SaveChanges();

            _programView.SetMessage("Program Deleted Successfully");
            LoadProgramList();
        }

        private void UpdateEvent(object? sender, EventArgs e)
        {
            try
            {
                var editProgram = _dbContext.Programs.Find(_programView.ProgramId);
                if (editProgram == null)
                {
                    _programView.SetMessage("Program Not Found");
                    return;
                }

                using (var createProgram = new CreateProgramView(editProgram))
                {
                    createProgram.Text = "Edit Program";
                    if (createProgram.ShowDialog() == DialogResult.OK)
                    {
                        LoadProgramList();

                    }
                }
            }
            catch (Exception ex)
            {
                _programView.SetMessage($"Error: {ex.Message}");
                return;
            }
            finally
            {
                LoadProgramList();
            }
        }

        private async void ReadEvent(object? sender, EventArgs e)
        {
            //var entity = await _dbContext.Programs
            //    .Where(c => c.ProgramId == _programView.ProgramId)
            //    .ToListAsync();

            LoadProgramList(_programView.SearchValue);
        }

        private void CreateEvent(object? sender, EventArgs e)
        {
            using (var createProgram = new CreateProgramView())
            {
                if (createProgram.ShowDialog() == DialogResult.OK)
                {
                    LoadProgramList();

                }
            }
        }
    }
}
