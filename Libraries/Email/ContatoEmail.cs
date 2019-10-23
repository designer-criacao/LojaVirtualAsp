using Loja.Models;
using System.Net.Mail;
using System.Net;

namespace Loja.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            //SMTP -> Servidor que vai enviar a mensagem
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Crendetials = new NetworkCredential("soidesigncriacao@gmail.com", "criatividadedez");
            smtp.EnableSsl = true;

            //MailMessage -> Construir a mensagem
            MailMessage mensagem = new MailMessage();

        }
    }
}