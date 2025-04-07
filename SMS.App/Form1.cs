using SMS.Domain;
using SMS.Infastructure.Data;

namespace SMS.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                var program = dbContext.Programs.Where(p => p.ProgramName == "EE").FirstOrDefault();
                createStudent(program.ProgramId, program.ProgramName, program.Description);
            }
            //buttonShow_Click(sender, e);
            //createStudent(1, "John Doe", "john@doe.com");
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            createStudent(2, "Juan Dela Cruz", "juan@delacruz.com");
        }

        private void createStudent(int id, string name, string email)
        {
            var student = new Student
            {
                StudentId = id,
                StudentName = name,
                Email = email,
                DateAdded = DateTime.Now,
                AddedBy = "Admin"
            };

            textBoxId.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
            textBoxEmail.Text = student.Email;

            //labelAddedInformation.Text = "Added by: " + student.AddedBy + " " + student.DateAdded;
            labelAddedInformation.Text = $"Added by: {student.AddedBy} {student.DateAdded}";
        }
    }
}
