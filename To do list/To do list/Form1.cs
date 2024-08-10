using System.Data;

namespace To_do_list
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }


        DataTable todolist = new DataTable();
        bool isEdditing = false;



        private void Form1_Load(object sender, EventArgs e)
        {
            //vytvoøení sloupcù
            todolist.Columns.Add("title");
            todolist.Columns.Add("Description");

            //Nasmìrovat datagridview do zdroje dat

            ToDoListView.DataSource = todolist;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleTextbox.Text = "";
            descriptionTextbox.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isEdditing = true;
            //fill text fields with data from table
            TitleTextbox.Text = todolist.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextbox.Text = todolist.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                todolist.Rows[ToDoListView.CurrentCell.RowIndex].Delete();

            }
            catch (Exception ex)
            {
                Console.WriteLine("error: " + ex);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(isEdditing)
            {
                todolist.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = TitleTextbox.Text;
                todolist.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextbox.Text;

            }
            else
            {
            todolist.Rows.Add(TitleTextbox.Text,descriptionTextbox.Text);
            }
            //clear fields
            TitleTextbox.Text = "";
            descriptionTextbox.Text = "";
            isEdditing = false; 
            
     

        }
    }
}
