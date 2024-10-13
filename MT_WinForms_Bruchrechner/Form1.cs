namespace MT_WinForms_Bruchrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e) // Methode f�r beim Clicken vom Plus Button 
        {

            int Z�hler1 = Convert.ToInt32(Z�hler_1.Text); // Speichern des ersten Z�hlers
            int Z�hler2 = Convert.ToInt32(Z�hler_2.Text);// Speichern des zweiten Z�hlers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text); // Speichern des ersten Nenners
            int Nenner2 = Convert.ToInt32(Nenner_2.Text);// Speichern des zweiten Nenners

            int Z�hler_neu = Nenner1 * Z�hler2 + Nenner2 * Z�hler1; // Berchnen von neuem Z�hler  
            int Nenner_neu = Nenner1 * Nenner2;// Bercehnen von neuem Nenner

            string[] K = K�rzen(Z�hler_neu, Nenner_neu).Split(" "); // Spliten des Strings nach dem K�rzen und einf�gen in Array

            Z�hler_neu = Convert.ToInt32(K[0]);// Extrahieren der Zahlen aus dem Array
            Nenner_neu = Convert.ToInt32(K[1]);

            Z�hler_End.Text = Convert.ToString(Z�hler_neu); //Ausgabe der Zahlen 
            Nenner_End.Text = Convert.ToString(Nenner_neu);



        }


        private string K�rzen(int Z�hler_neu, int Nenner_neu) // Methode zum K�rzen
        {

            int ggt = GGT(Z�hler_neu, Nenner_neu); // Gr��ter Gemeinsamer Teiler in Variable gespeihert
            Z�hler_neu /= ggt; // k�rzen durch dividieren
            Nenner_neu /= ggt;
            string K = Z�hler_neu.ToString() + " " + Nenner_neu.ToString(); // speichern von Z�hler und Nenner in K
            return K; 
        }

        private int GGT(int a, int b) // Methode zum berchnen vom GGt
        {

            while (b != 0) // Euklidischer Algorithmus
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;

        }

        private void Minus_Click(object sender, EventArgs e)// Methode beim Clicken vom Minus Button 
        {

            int Z�hler1 = Convert.ToInt32(Z�hler_1.Text);// Speichern des ersten Z�hlers
            int Z�hler2 = Convert.ToInt32(Z�hler_2.Text);// Speichern des zweiten Z�hlers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners
            int Nenner2 = Convert.ToInt32(Nenner_2.Text);// Speichern des ersten Nenners

            int Z�hler_neu = Nenner1 * Z�hler2 - Nenner2 * Z�hler1;// Berchnen von neuem Z�hler  
            int Nenner_neu = Nenner1 * Nenner2;// Bercehnen von neuem Nenner

            string[] K = K�rzen(Z�hler_neu, Nenner_neu).Split(" "); // Spliten des Strings nach dem K�rzen und einf�gen in Array


            Z�hler_neu = Convert.ToInt32(K[0]);// Extrahieren der Zahlen aus dem Array
            Nenner_neu = Convert.ToInt32(K[1]);

            Z�hler_End.Text = Convert.ToString(Z�hler_neu); //Ausgabe der Zahlen 
            Nenner_End.Text = Convert.ToString(Nenner_neu);

        }

        private void Mal_Click(object sender, EventArgs e) // Methode  beim Clicken vom Mal Button
        {

            int Z�hler1 = Convert.ToInt32(Z�hler_1.Text);// Speichern des ersten Z�hlers
            int Z�hler2 = Convert.ToInt32(Z�hler_2.Text);// Speichern des zweiten Z�hlers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners
            int Nenner2 = Convert.ToInt32(Nenner_2.Text);// Speichern des zweiten Nenners

            int Z�hler_neu = Z�hler1 * Z�hler2;// Berchnen von neuem Z�hler
            int Nenner_neu = Nenner1 * Nenner2;// Bercehnen von neuem Nenner

            string[] K = K�rzen(Z�hler_neu, Nenner_neu).Split(" ");// Spliten des Strings nach dem K�rzen und einf�gen in Array

            Z�hler_neu = Convert.ToInt32(K[0]);// Extrahieren der Zahlen aus dem Array
            Nenner_neu = Convert.ToInt32(K[1]);

            Z�hler_End.Text = Convert.ToString(Z�hler_neu);//Ausgabe der Zahlen 
            Nenner_End.Text = Convert.ToString(Nenner_neu);


        }

        private void Divisor_Click(object sender, EventArgs e)// Methode  beim Clicken vom Mal Button
        {

            int Z�hler1 = Convert.ToInt32(Z�hler_1.Text);// Speichern des ersten Z�hlers
            int Z�hler2 = Convert.ToInt32(Z�hler_2.Text);// Speichern des zweiten Z�hlers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners
            int Nenner2 = Convert.ToInt32(Nenner_2.Text);// Speichern des zweiten Nenners

            int Z�hler_neu = Z�hler1 * Nenner2;// Berchnen von neuem Z�hler
            int Nenner_neu = Nenner1 * Z�hler2;// Bercehnen von neuem Nenner

            string[] K = K�rzen(Z�hler_neu, Nenner_neu).Split(" ");// Spliten des Strings nach dem K�rzen und einf�gen in Array


            Z�hler_neu = Convert.ToInt32(K[0]);// Extrahieren der Zahlen aus dem Array
            Nenner_neu = Convert.ToInt32(K[1]);


            Z�hler_End.Text = Convert.ToString(Z�hler_neu);//Ausgabe der Zahlen
            Nenner_End.Text = Convert.ToString(Nenner_neu);

        }

        private void Potenz_Click(object sender, EventArgs e)// Methode  beim Clicken vom Mal Button
        {

            int Z�hler1 = Convert.ToInt32(Z�hler_1.Text);// Speichern des ersten Z�hlers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners

            int Z�hler_neu = (int)Math.Pow(Z�hler1, Convert.ToInt32(Exponent.Text));// Berchnen von neuem Z�hler
            int Nenner_neu = (int)Math.Pow(Nenner1, Convert.ToInt32(Exponent.Text));// Bercehnen von neuem Nenner

            Z�hler_End.Text = Convert.ToString(Z�hler_neu);
            Nenner_End.Text = Convert.ToString(Nenner_neu);//Ausgabe der Zahlen

        }



        private void Wurzel_Click(object sender, EventArgs e)
        {


            int Z�hler1 = Convert.ToInt32(Z�hler_1.Text);// Speichern des ersten Z�hlers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners


            int Z�hler_neu = (int)Math.Sqrt(Z�hler1);// Berchnen von neuem Z�hler
            int Nenner_neu = (int)Math.Sqrt(Nenner1);// Bercehnen von neuem Nenner

            Z�hler_End.Text = Convert.ToString(Z�hler_neu);//Ausgabe der Zahlen
            Nenner_End.Text = Convert.ToString(Nenner_neu);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
