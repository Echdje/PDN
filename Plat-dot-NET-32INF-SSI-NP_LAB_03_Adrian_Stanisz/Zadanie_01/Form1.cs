namespace Zadanie_01
{
    public partial class Form1 : Form
    {
        DateTimePicker startPicker, endPicker;
        Button toCountButton;
        Label resultLabel;
        DateTime startTime, endTime;
        public Form1()
        {
            InitializeComponent();
            InitializeComponents();
        }
        void InitializeComponents() {
            startPicker = new DateTimePicker()
            {
                Location = new Point(50, 50), // polozenie w GUI, od tego punktu widac element 
                Size = new Size(150, 50), // rozmair elementu
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd.MM.yyyy HH:mm:ss"
            };
            this.Controls.Add(startPicker);

            endPicker = new DateTimePicker()
            {
                Size = new Size(150, 50),
                Location = new Point(250, 50),
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd.MM.yyyy HH:mm:ss"
            };
            this.Controls.Add(endPicker);

            toCountButton = new Button()
            {
                Size = new Size(70,50),
                Location = new Point(175,200),
                Text = "Calculate"
            };
            this.Controls.Add(toCountButton);
            toCountButton.Click += ToCountButton_Click;

            resultLabel = new Label()
            {
                Size = new Size(200,150),
                Location = new Point(150,350),
                Text = "Result: ",
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            this.Controls.Add(resultLabel);

        }

        TimeSpan calculateTime(DateTime start, DateTime end) {
            TimeSpan timeSpan = (start - end).Duration();
            return timeSpan;
        }

        private void ToCountButton_Click(object? sender, EventArgs e)
        {
            resultLabel.Text = "";
            startTime = startPicker.Value;
            endTime = endPicker.Value;
            TimeSpan diff = calculateTime(startTime, endTime);

            resultLabel.Text += $"Result: {diff.Days} days {diff.Hours} hours {diff.Minutes} minutes {diff.Seconds} seconds";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
