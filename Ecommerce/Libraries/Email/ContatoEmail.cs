using System;
using System.Net;
using System.Net.Mail;
using LojaVirtualCsharp.Models;

namespace LojaVirtualCsharp.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com" , 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("matttheus.reee@gmail.com","breakingbad");
            smtp.EnableSsl = true;
            smtp.Timeout = 2000000;

             string corpoMsg = string.Format("<h2>Contato - LojaVirtual</h2>" +
                "<b>Nome: </b> {0} <br />" +
                "<b>E-mail: </b> {1} <br />" +
                "<b>Texto: </b> {2} <br />" +
                "<br /> E-mail enviado automaticamente do site LojaVirtual.",
                contato.Nome,
                contato.Email,
                contato.Texto
            );


            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("matttheus.reee@gmail.com");
            mensagem.To.Add("matttheus.reee@gmail.com");
            mensagem.Subject = "Contato Loja Virtual";
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            //Enviar Mensagem via SMTP
            smtp.Send(mensagem);
        }
    }
}