namespace MainProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 123123;
            double decima = 32.23;
            int edad = 10;
            bool esMayor = edad >= 18;

            if (esMayor)
            {
                label2.Text = "Si es mayor";
            }
            else
            {
                label2.Text = "Lo siento, es menor";
            }


            string prueba = "Mira como cambio papa" + decima;
            prueba = "Asi es" + numero;
            textoNumeroUno.Text = "ASi es " + prueba;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoEdad = inputText.Text;
            int edad = Int32.Parse(textoEdad);

            bool greaterThan = edad >= 18; //boolean
            //true , false
            if (greaterThan)
            {
                result.Text = "Eres mayor de edad";
            }
            else
            {
                result.Text = "Eres menor de edad";
            }

        }
        /**/
        //
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Set the input values
            string inputPeso = textBox1.Text;
            string inputAltura = textBox2.Text;

            // Convert to number value
            double alturaTxt = Double.Parse(inputAltura); //double instead of int32
            double pesoTxt = Double.Parse(inputPeso);

            // w / h to 2



            double resultado = pesoTxt / (alturaTxt * alturaTxt);



            MessageBox.Show("El indice de masa muscular es " + resultado);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string numberOne = numOne.Text;
            string numberTwo = numTwo.Text;

            int numeroUno = Int32.Parse(numberOne);
            int numeroDos = Int32.Parse(numberTwo);

            int suma = numeroDos + numeroUno;

            MessageBox.Show("la suma es  " + suma);

            //Array

            //Create new List
            List<int> lista = new List<int>();
            //Add index
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);
            lista.Add(6);

            for(int i = 0; i < lista.Count; i++)
            {
                int numero = lista[i];
                MessageBox.Show("EL numero es " + numero);
            }


        }
    }
}
