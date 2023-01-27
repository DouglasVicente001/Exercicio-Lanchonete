namespace ConsolesC_.Models
{
    public class Produto
    {

        public double LancheCarne { get; set; }
        public double LancheFrango { get; set; }
        public double BatataFrita { get; set; }
        public double Refrigerante { get; set; }
        public Produto(double LancheFrango, double LancheCarne, double BatataFrita, double Refrigerante)
        {
            this.LancheCarne = LancheCarne;
            this.LancheFrango = LancheFrango;
            this.BatataFrita = BatataFrita;
            this.Refrigerante = Refrigerante;
        }

    }
}