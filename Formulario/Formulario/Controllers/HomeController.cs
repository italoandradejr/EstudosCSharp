using System.Diagnostics;
using Formulario.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;

namespace Formulario.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SendContact(ContactViewModel model)
    {
        if(!ModelState.IsValid)
        {
            ViewData["Message"] = "Informações inválidas!";
			return View("Contact");
		}

        var emailMessage = new MailMessage();
        emailMessage.Subject = "Contato de " + model.Nome;
        emailMessage.From = new MailAddress("italo.andrade@savoy.com.br");
        emailMessage.To.Add("suporte@savoy.com.br");
        emailMessage.IsBodyHtml = true;

        emailMessage.Body = "<p>Nome: " + model.Nome + "</p>" +
            "<p>Cargo: " + model.Cargo + "</p>" +
            "<p>Empresa: " + model.Empresa + "</p>" +
            "<p>Fone: " + model.Fone + "</p>" +
            "<p>Email: " + model.Email + "</p>" +
            "<p>Assunto: " + model.Assunto + "</p>" +
            "<p>Mensagem: " + model.Mensagem + "</p>";

        var client = new SmtpClient("email-ssl.com.br", 587);

        client.Credentials = new NetworkCredential("italo.andrade@savoy.com.br", "S@voy1611");
        client.EnableSsl = true;

        try
        {
            client.Send(emailMessage);
			
		} catch (Exception ex)
        {
            ViewData["message"] = "Falha ao Enviar!" + ex.Message;
        }

		return View("SendContact");
	}

}
