namespace Moreno.CanalDeOfertas.Domain.Value_Objects;

public sealed class CNPJ
{
    public static bool Validar(string cnpj)
    {
        var multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        var multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int soma;
        int resto;
        string digito;
        string tempCnpj;
        cnpj = cnpj.Trim();
        cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
        if (cnpj.Length > 14)
            return false;

        cnpj = cnpj.PadLeft(14, '0');

        var igual = true;
        for (var i = 1; i < 14 && igual; i++)
            if (cnpj[i] != cnpj[0])
                igual = false;

        if (igual)
            return false;

        tempCnpj = cnpj[..12];
        soma = 0;

        for (var i = 0; i < 12; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
        resto = (soma % 11);
        resto = resto < 2 ? 0 : 11 - resto;

        digito = resto.ToString();
        tempCnpj += digito;
        soma = 0;

        for (var i = 0; i < 13; i++)
            soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

        resto = (soma % 11);
        resto = resto < 2 ? 0 : 11 - resto;
        digito += resto.ToString();
        return cnpj.EndsWith(digito);
    }
}
