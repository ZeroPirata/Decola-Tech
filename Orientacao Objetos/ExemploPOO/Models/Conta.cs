namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double Saldo;
        public abstract void Creditar(double valor);
        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é " + Saldo);
        }
    }
}