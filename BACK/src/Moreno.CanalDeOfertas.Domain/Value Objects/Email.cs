using System.Net.Mail;

namespace Moreno.CanalDeOfertas.Domain.Value_Objects;

public sealed class Email
{
    public static bool Validar(string email)
    {
        if (string.IsNullOrWhiteSpace(email)) return false;
        try
        {
            var addr = new MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}
