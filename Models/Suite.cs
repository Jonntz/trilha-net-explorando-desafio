namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string tipoSuite)
        {
            TipoSuite = tipoSuite;
            

            if (tipoSuite == "Comum")
            {
                ValorDiaria = 10.00M;
                Capacidade = 5;  
            } else if (tipoSuite == "Premium"){
                ValorDiaria = 30.00M;
                Capacidade = 10;  
            }
        }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}