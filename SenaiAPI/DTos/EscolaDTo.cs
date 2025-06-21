namespace SenaiAPI.DTos
{
    public class EscolaDTo
    {
        public long Id { get; set; }
        public string nome { get; set; }

        public EnderecoDTo Endereco { get; set; }
    }
}
