namespace ClassSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnimalInstanceCreate_Click(object sender, EventArgs e)
        {
            Animal cat = new Animal();
            Animal dog = new Animal();

            cat.name = "ƒlƒR";
            cat.color = "”’";
            textBoxName1.Text = cat.name;
            textBoxColor1.Text = cat.color;
            textBoxSing1.Text = cat.Sing();

            dog.name = "ƒCƒk";
            dog.color = "’ƒ";
            textBoxName2.Text = dog.name;
            textBoxColor2.Text = dog.color;
            textBoxSing2.Text = dog.Sing();


        }
    }
}
