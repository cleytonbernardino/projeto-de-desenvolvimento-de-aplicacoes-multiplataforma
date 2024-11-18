namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Utils
{
    internal class cpfUtils
    {
        private static int CalculateCheckDigit(string cpf, bool firstDigit)
        {
            int digit;
            int sum = 0;
            int cpfLen = cpf.Length - 2;
            int mult = 1;

            if (!firstDigit)
            {
                cpfLen = cpf.Length - 1;
                mult = 0;
            }

            for (int i = 0; i < cpfLen; i++)
            {
                digit = int.Parse(cpf[i].ToString());
                sum += digit + mult;
            }
            return sum;
        }

        public static bool IsCpfValid(string cpf)
        {
            if (cpf.Length != 11 || !cpf.All(Char.IsDigit)) return false;

            int firstDigit = CalculateCheckDigit(cpf, true);
            int secondDigit = CalculateCheckDigit(cpf, false);

            string cpfVerified = cpf.Substring(0, 9) + firstDigit + secondDigit;


            if (cpfVerified != cpf) return false;
            return true;
        }

        public static string ToCpf(string cpf)
        {
            return cpf.Replace(".", "").Replace("-", "");
        }
    }
}
