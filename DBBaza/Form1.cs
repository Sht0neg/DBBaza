using Microsoft.EntityFrameworkCore;

namespace DBBaza
{
    public partial class Form1 : Form
    {
        Context? context;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new Context();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Categories.Load();

            dataGridView1.DataSource = context.Categories.Local.ToBindingList(); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            context.Dispose();
            context = null;
        }
    }
}
