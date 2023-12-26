namespace TestesUnitarios.Desafio.Console.Services {
    public class ValidacoesString {
        public static int RetornarQuantidadeCaracteres(string texto) {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }

        public static bool ContemCaractere(string texto, string textoProcurado) {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }

        public static bool TextoTerminaCom(string texto, string textoProcurado) {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}