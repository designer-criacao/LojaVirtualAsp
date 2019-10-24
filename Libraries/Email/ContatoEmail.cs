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
            smtp.Credentials = new NetworkCredential("soidesigncriacao@gmail.com", "***************");
            smtp.EnableSsl = true;

            string corpoMsg = string.Format("<h2>Contato - Loja Virtual</h2>" + 
                            "<b>Nome: </b> {0} <br/>" +
                            "<b>E-mail: </b> {1} <br/>" +
                            "<b>Texto: </b> {2} <br />" +
                            "<br />E-mail Enviado automaticamente do site LojaVirtual.",
                            contato.Nome,
                            contato.Email,
                            contato.Texto 
                            );
            //MailMessage -> Construir a mensagem
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("soidesigncriacao@gmail.com");
            mensagem.To.Add("soidesigncriacao@gmail.com");
            mensagem.Subject = "Contato - Loja Virtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //Enviar E-mail via 'smtp'
            smtp.Send(mensagem);
        }
    }
}