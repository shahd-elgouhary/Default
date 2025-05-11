using System.Windows.Forms;

namespace HotelApp
{
    public partial class Form1 : Form
    {
        BindingSource guestbindingSource = new BindingSource();
        BindingSource bookingsbindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuestSDAO guestSDAO = new GuestSDAO();

            guestbindingSource.DataSource = guestSDAO.getAllGuests();

            dataGridView1.DataSource = guestbindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuestSDAO guestSDAO = new GuestSDAO();

            guestbindingSource.DataSource = guestSDAO.searchNames(textBox1.Text);

            dataGridView1.DataSource = guestbindingSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add a new item to the database

            Guest guest = new Guest
            {
                Name = txt_guestName.Text,
                Email = txt_guestEmail.Text,
                Phone_Number = Convert.ToInt32(txt_guestPhone_Number.Text),
                Password = Convert.ToInt32(txt_guestPassword.Text)
            };

            GuestSDAO guestSDAO = new GuestSDAO();
            int result = guestSDAO.addOneGuest(guest);
            MessageBox.Show(result + "New row(s) inserted");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;

            GuestSDAO guestSDAO = new GuestSDAO();

            bookingsbindingSource.DataSource = guestSDAO.getBookingsForGuest((int)dataGridView.Rows[rowClicked].Cells[0].Value);

            dataGridView2.DataSource = bookingsbindingSource;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //get the row number clicked
            int rowClicked = dataGridView2.CurrentRow.Index;
            MessageBox.Show("You Clicked Row" + rowClicked);
            int bookingID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("ID of Booking" + bookingID);

            GuestSDAO guestSDAO= new GuestSDAO();

            int result = guestSDAO.deleteBooking(bookingID);

            MessageBox.Show("Result" + result);

            dataGridView2.DataSource = null;
            guestbindingSource.DataSource = guestSDAO.getAllGuests();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
