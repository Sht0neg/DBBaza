using Microsoft.EntityFrameworkCore;

namespace DZ
{
    public partial class Form1 : Form
    {
        Context? context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new Context();
            context.Database.EnsureCreated();
            context.Employees.Load();

            employeeBindingSource.DataSource = context.Employees.Local.ToBindingList();
        }
    }
}
