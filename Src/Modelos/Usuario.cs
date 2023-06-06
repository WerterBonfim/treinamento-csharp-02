using System.Text.RegularExpressions;

namespace Modelos;

public class Usuario
{
    public Usuario(Guid id, string nome, string email, string senha)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Senha = senha;
    }

    /// <summary>
    /// Id obrigátorio
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Campo obrigátorio, minimo de 3 carctares, maximo de 50 caracteres
    /// </summary>
    public string Nome { get; set; }
    
    /// <summary>
    /// Email obrigatório, com no maximo 50 caractares
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Senha obrigatório, com no minimo 6 digitos e no maixmo 40 digitos
    /// </summary>
    public string Senha { get; set; }
    
    
    

    public bool EstaValido()
    {
        if (string.IsNullOrEmpty(Nome) || Nome.Length < 3 || Nome.Length > 50)
            return false;

        var emailEstáInvalido = !Regex.IsMatch(Email, @"\w.+@.+\.\w");
        if (emailEstáInvalido)
            return false;

        var senhaInvalida = string.IsNullOrEmpty(Senha) || Senha.Length < 6 || Senha.Length > 40;
        if (senhaInvalida)
            return false;
            
        
        return true;
    }
}
