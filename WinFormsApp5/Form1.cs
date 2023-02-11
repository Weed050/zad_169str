namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            Echo e1 = new Echo();
            Echo e2 = new Echo();
            int x = 0;
            while(x<4 && Visible)
            {
                result = result + e1.Hello()+"\n";
                e1.count= e1.count+1;
                if (x > 0 && Visible)
                {
                    e2.count = e2.count + 1;
                    
                }
                if (x>1 && Visible)
                {
                    e2.count= e2.count + e1.count;
                }
                x++;
            }
            MessageBox.Show(result + "Licznik: "+e2.count);
        }
        public class Echo
        {
            public int count = 0;
            public string Hello()
            {
                return "witaj...";
            }

        }
    }
}