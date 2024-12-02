namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Utils
{
    internal class cpfUtils
    {
        private static int CalculateCheckDigit(string cpf, bool firstDigit)
        {
            int digit, result;
            int sum = 0;
            int cpfLen = cpf.Length - 2;
            int mult = 10;

            if (!firstDigit)
            {
                cpfLen = cpf.Length - 1;
                mult = 11;
            }

            for (int i = 0; i < cpfLen; i++)
            {
                digit = int.Parse(cpf[i].ToString());
                sum += digit * mult;
                mult--;
            }
            result = 11 - (sum % 11);
            return result >= 11? 0 : result;
        }

        public static bool IsCpfValid(string cpf)
        {
            if (cpf.Length == 14) cpf = ToCpf(cpf);
            if (cpf.Length != 11 || !cpf.All(Char.IsDigit)) return false;

            int firstDigit = CalculateCheckDigit(cpf, true);
            int secondDigit = CalculateCheckDigit(cpf, false);

            string cpfVerified = cpf.Substring(0, 9) + firstDigit + secondDigit;

            return cpfVerified == cpf;
        }

        public static string ToCpf(string cpf)
        {
            return cpf.Replace(".", "").Replace("-", "");
        }
    }
}
