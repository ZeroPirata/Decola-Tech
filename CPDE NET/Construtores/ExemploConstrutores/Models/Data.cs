namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;


        public void setMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }
        public int Mes
        {
            get
            {
                return this.mes;
            }
            set
            {
                if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        }
        public int getMes()
        {
            return this.mes;
        }
        public void Apresnetar()
        {
            if (this.mesValido)
            {
                System.Console.WriteLine("Mês valido");
            }
            else
            {
                System.Console.WriteLine("Mês invalido");
            }
        }
    }
}