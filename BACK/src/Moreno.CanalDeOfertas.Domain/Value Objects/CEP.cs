using System.Text.RegularExpressions;

namespace Moreno.CanalDeOfertas.Domain.Value_Objects;

public partial class CEP
{
    public static bool ValidaCEP(string cep) => MyRegex().IsMatch(cep);

    [GeneratedRegex("^\\d{5}-\\d{3}$")]
    private static partial Regex MyRegex();
}
