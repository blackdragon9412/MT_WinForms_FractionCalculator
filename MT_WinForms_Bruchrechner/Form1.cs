namespace MT_WinForms_Bruchrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e) // Methode für beim Clicken vom Plus Button 
        {

            int Zähler1 = Convert.ToInt32(Zähler_1.Text); // Speichern des ersten Zählers
            int Zähler2 = Convert.ToInt32(Zähler_2.Text);// Speichern des zweiten Zählers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text); // Speichern des ersten Nenners
            int Nenner2 = Convert.ToInt32(Nenner_2.Text);// Speichern des zweiten Nenners

            int Zähler_neu = Nenner1 * Zähler2 + Nenner2 * Zähler1; // Berchnen von neuem Zähler  
            int Nenner_neu = Nenner1 * Nenner2;// Bercehnen von neuem Nenner

            string[] K = Kürzen(Zähler_neu, Nenner_neu).Split(" "); // Spliten des Strings nach dem Kürzen und einfügen in Array

            Zähler_neu = Convert.ToInt32(K[0]);// Extrahieren der Zahlen aus dem Array
            Nenner_neu = Convert.ToInt32(K[1]);

            Zähler_End.Text = Convert.ToString(Zähler_neu); //Ausgabe der Zahlen 
            Nenner_End.Text = Convert.ToString(Nenner_neu);



        }


        private string Kürzen(int Zähler_neu, int Nenner_neu) // Methode zum Kürzen
        {

            int ggt = GGT(Zähler_neu, Nenner_neu); // Größter Gemeinsamer Teiler in Variable gespeihert
            Zähler_neu /= ggt; // kürzen durch dividieren
            Nenner_neu /= ggt;
            string K = Zähler_neu.ToString() + " " + Nenner_neu.ToString(); // speichern von Zähler und Nenner in K
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

            int Zähler1 = Convert.ToInt32(Zähler_1.Text);// Speichern des ersten Zählers
            int Zähler2 = Convert.ToInt32(Zähler_2.Text);// Speichern des zweiten Zählers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners
            int Nenner2 = Convert.ToInt32(Nenner_2.Text);// Speichern des ersten Nenners

            int Zähler_neu = Nenner1 * Zähler2 - Nenner2 * Zähler1;// Berchnen von neuem Zähler  
            int Nenner_neu = Nenner1 * Nenner2;// Bercehnen von neuem Nenner

            string[] K = Kürzen(Zähler_neu, Nenner_neu).Split(" "); // Spliten des Strings nach dem Kürzen und einfügen in Array


            Zähler_neu = Convert.ToInt32(K[0]);// Extrahieren der Zahlen aus dem Array
            Nenner_neu = Convert.ToInt32(K[1]);

            Zähler_End.Text = Convert.ToString(Zähler_neu); //Ausgabe der Zahlen 
            Nenner_End.Text = Convert.ToString(Nenner_neu);

        }

        private void Mal_Click(object sender, EventArgs e) // Methode  beim Clicken vom Mal Button
        {

            int Zähler1 = Convert.ToInt32(Zähler_1.Text);// Speichern des ersten Zählers
            int Zähler2 = Convert.ToInt32(Zähler_2.Text);// Speichern des zweiten Zählers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners
            int Nenner2 = Convert.ToInt32(Nenner_2.Text);// Speichern des zweiten Nenners

            int Zähler_neu = Zähler1 * Zähler2;// Berchnen von neuem Zähler
            int Nenner_neu = Nenner1 * Nenner2;// Bercehnen von neuem Nenner

            string[] K = Kürzen(Zähler_neu, Nenner_neu).Split(" ");// Spliten des Strings nach dem Kürzen und einfügen in Array

            Zähler_neu = Convert.ToInt32(K[0]);// Extrahieren der Zahlen aus dem Array
            Nenner_neu = Convert.ToInt32(K[1]);

            Zähler_End.Text = Convert.ToString(Zähler_neu);//Ausgabe der Zahlen 
            Nenner_End.Text = Convert.ToString(Nenner_neu);


        }

        private void Divisor_Click(object sender, EventArgs e)// Methode  beim Clicken vom Mal Button
        {

            int Zähler1 = Convert.ToInt32(Zähler_1.Text);// Speichern des ersten Zählers
            int Zähler2 = Convert.ToInt32(Zähler_2.Text);// Speichern des zweiten Zählers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners
            int Nenner2 = Convert.ToInt32(Nenner_2.Text);// Speichern des zweiten Nenners

            int Zähler_neu = Zähler1 * Nenner2;// Berchnen von neuem Zähler
            int Nenner_neu = Nenner1 * Zähler2;// Bercehnen von neuem Nenner

            string[] K = Kürzen(Zähler_neu, Nenner_neu).Split(" ");// Spliten des Strings nach dem Kürzen und einfügen in Array


            Zähler_neu = Convert.ToInt32(K[0]);// Extrahieren der Zahlen aus dem Array
            Nenner_neu = Convert.ToInt32(K[1]);


            Zähler_End.Text = Convert.ToString(Zähler_neu);//Ausgabe der Zahlen
            Nenner_End.Text = Convert.ToString(Nenner_neu);

        }

        private void Potenz_Click(object sender, EventArgs e)// Methode  beim Clicken vom Mal Button
        {

            int Zähler1 = Convert.ToInt32(Zähler_1.Text);// Speichern des ersten Zählers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners

            int Zähler_neu = (int)Math.Pow(Zähler1, Convert.ToInt32(Exponent.Text));// Berchnen von neuem Zähler
            int Nenner_neu = (int)Math.Pow(Nenner1, Convert.ToInt32(Exponent.Text));// Bercehnen von neuem Nenner

            Zähler_End.Text = Convert.ToString(Zähler_neu);
            Nenner_End.Text = Convert.ToString(Nenner_neu);//Ausgabe der Zahlen

        }



        private void Wurzel_Click(object sender, EventArgs e)
        {


            int Zähler1 = Convert.ToInt32(Zähler_1.Text);// Speichern des ersten Zählers
            int Nenner1 = Convert.ToInt32(Nenner_1.Text);// Speichern des ersten Nenners


            int Zähler_neu = (int)Math.Sqrt(Zähler1);// Berchnen von neuem Zähler
            int Nenner_neu = (int)Math.Sqrt(Nenner1);// Bercehnen von neuem Nenner

            Zähler_End.Text = Convert.ToString(Zähler_neu);//Ausgabe der Zahlen
            Nenner_End.Text = Convert.ToString(Nenner_neu);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
