using Modelos;

namespace Werter.VendaMais.Testes.Modelos;

public class UsuarioTestes
{
    [Fact]
    public void DeveriaNotificaSucessoAoCriarUmNovoUsuario()
    {
        // [ Arrange ]

        var usuario = new Usuario(
            Guid.NewGuid(),
            "werter",
            "werter@empresa.com",
            "123456"
        );


        // [ Act ]

        var usuarioEstáValido = usuario.EstaValido();


        // [ Assert ]

        Assert.True(usuarioEstáValido);
    }
    
    
    [Fact]
    public void DeveriaNotificarErro_NomeInválido()
    {
        // [ Arrange ]

        var usuario = new Usuario(
            Guid.NewGuid(),
            "",
            "werter@empresa.com",
            "123456"
        );


        // [ Act ]

        var usuarioEstáValido = usuario.EstaValido();


        // [ Assert ]

        Assert.False(usuarioEstáValido, "nome está em branco");
    }
    
    [Fact]
    public void DeveriaNotificarErro_EmailInvalido()
    {
        // [ Arrange ]

        var usuario = new Usuario(
            Guid.NewGuid(),
            "werer",
            "werte",
            "123456"
        );


        // [ Act ]

        var usuarioEstáValido = usuario.EstaValido();


        // [ Assert ]

        Assert.False(usuarioEstáValido, "Email inválido");
    }
    
    
    [Fact]
    public void DeveriaNotificarErro_SenhaInvalida()
    {
        // [ Arrange ]

        var usuario = new Usuario(
            Guid.NewGuid(),
            "werer",
            "werter@gmail.com",
            "1"
        );


        // [ Act ]

        var usuarioEstáValido = usuario.EstaValido();


        // [ Assert ]

        Assert.False(usuarioEstáValido, "Senha inválido");
    }
    
    
}