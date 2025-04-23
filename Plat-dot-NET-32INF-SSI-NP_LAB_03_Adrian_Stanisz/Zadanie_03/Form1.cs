namespace Zadanie_03
{
    public partial class Form1 : Form
    {
        TextBox pBox, qBox, eBox, dBox, textToCrypt, textEncrypt;
        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
        }
        void InitializeComponents() {
            pBox = new TextBox()
            {
                Size = new Size(100, 50),
                Location = new Point(50, 50),
                PlaceholderText = "pValue"
            };
            this.Controls.Add(pBox);
            
            qBox = new TextBox()
            {
                Size = new Size(100, 50),
                Location = new Point(200, 50),
                PlaceholderText = "qValue"
            };
            this.Controls.Add(qBox);
            
            eBox = new TextBox()
            {
                Size = new Size(100, 50),
                Location = new Point(50, 150),
                PlaceholderText = "eValue"
            };
            this.Controls.Add(eBox);
            
            dBox = new TextBox()
            {
                Size = new Size(100, 50),
                Location = new Point(200, 150),
                PlaceholderText = "dValue"
            };
            this.Controls.Add(dBox);

            textToCrypt = new TextBox()
            {
                Size = new Size(300, 80),
                Location = new Point(50, 220),
                PlaceholderText = "text to ecnrypt",
                Multiline = true
            };
            this.Controls.Add(textToCrypt);

            textEncrypt = new TextBox()
            {
                Size = new Size(300, 80),
                Location = new Point(50, 320),
                PlaceholderText = "Encrypted text",
                Multiline = true
            };
            this.Controls.Add(textEncrypt);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
