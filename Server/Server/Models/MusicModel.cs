namespace Server.Models
{
    public class MusicModel
    {
        private int? year;
        private string artista;

        public MusicModel(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Id { get; set; }
        public string Artista
        {
            get => artista;
            set
            {
                if (value is null || value == "")
                {
                    artista = "Artista desconhecido";
                }
                else
                {

                    artista = value;
                }
            }
        }

        public int? Year
        {
            get => year;
            set
            {
                if (value <= 0)
                {
                    year = null;
                }
                else
                {

                    year = value;
                }
            }
        }
        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");

        }

        public override string ToString()
        {
            return @$"Id: {Id} Nome: {Nome}";
        }

    }
}
