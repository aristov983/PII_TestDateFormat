using System.Runtime.InteropServices.JavaScript;
using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    //ARRANGE : Preparas las clases

    //ACT : Ejecutar metodo o accion a probar
    
    //Assert : Verificar que el resultado es el esperado

    [Test]
    public void ChangeFormat_ValidInputDate_ReturnsConvertedDate()
    {
        DateFormatter formatter = new DateFormatter();
        string entrada = "09/12/2025";
        string resultado = formatter.ChangeFormat(entrada);
        Assert.That("2025-12-09", Is.EqualTo(resultado)); 
    }

    [Test]
    public void ChangeFormat_InvalidInputDate_ReturnsEmpty()
    {
        DateFormatter formatter = new DateFormatter();
        string entrada = "Manteca con pan";
        string resultado = formatter.ChangeFormat(entrada);
        Assert.That(resultado, Is.Empty);
    }

    [Test]
    public void ChangeFormat_EmptyInput_ReturnsEmpty()
    {
        DateFormatter formatter = new DateFormatter();
        string entrada = "";
        string resultado = formatter.ChangeFormat(entrada);
        Assert.That(resultado, Is.Empty);
    }
    
    
}   