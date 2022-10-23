using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "O sobrenome é requerido.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "O email é requerido.")]        
        public string Email { get; set; }

        [Display(Name = "Ativo")]
        public bool Ative { get; set; }
    }
}


//public class UsuarioModelCadastro
//{
//    [Required(ErrorMessage = "Por favor, informe o nome do usuario.")]
//    [RegularExpression("^[A-Za-zÀ-Üà-ü\\s]{6,50}$",
//    ErrorMessage = "Erro. Nome inválido.")]
//    [Display(Name = "Informe seu Nome:")] //label
//    public string Nome { get; set; } //campo


//    [Required(ErrorMessage = "Por favor, informe o email do usuario.")]
//    [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
//    ErrorMessage = "Erro. Email inválido.")]
//    [Display(Name = "Email de Acesso:")] //label
//    [LoginDisponivel(ErrorMessage = "Erro. Este login encontra-se indisponivel.Tente outro.")]
//    public string Email { get; set; } //campo


//    [Required(ErrorMessage = "Por favor, informe a senha do usuario.")]
//    [RegularExpression("^[A-Za-z0-9@]{6,20}$",
//    ErrorMessage = "Erro. Senha inválida.")]
//    [Display(Name = "Senha de Acesso:")] //label
//    public string Senha { get; set; } //campo


//    [Required(ErrorMessage = "Por favor, confirme a senha do usuario.")]
//    [Compare("Senha",
//    ErrorMessage = "Erro. Confirme sua Senha corretamente.")]
//    [Display(Name = "Confirme sua Senha:")] //label
//    public string SenhaConfirm { get; set; } //campo
//}