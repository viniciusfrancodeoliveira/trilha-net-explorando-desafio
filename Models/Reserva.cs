namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verifica se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            
                if (hospedes.Count <= Suite.Capacidade)
                    {
                        Hospedes = hospedes;
                    }
                    else
                    {
                        throw new SystemException("A quantidade de hóspedes não pode exceder a capacidade da suíte");
                    }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes 
            int quantidadeDeHospedes = Hospedes.Count;
            return quantidadeDeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

           //Aplica 10% de Desconto se DiasReservados >= 10
            if (DiasReservados >= 10)
            {
                valor -= (valor /10);
            }
            return valor;
        }
    }
}