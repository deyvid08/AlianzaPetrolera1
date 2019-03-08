using AlianzaPetrolera.Controllers.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlianzaPetrolera.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "¿Recordar este explorador?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string Pers_NickNom { get; set; }

        [Required]
        [Display(Name = "Correo electrónico")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "¿Recordar cuenta?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Key]
        [Display(Name = "Codigo")]
        public string Pers_Cod { get; set; }

        [Required]
        [Display(Name = "Usuario")]
        public string Pers_NickNom { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirmar contraseña")]
        //[Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        //public string ConfirmPassword { get; set; }
        
        [Display(Name = "Nombres")]
        public string Pers_Nom { get; set; }
        [Display(Name = "Apellidos")]
        public string Pers_Lstn1 { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string Pers_Lstn2 { get; set; }
        [Display(Name = "Tipo de Documento")]
        public TipoDoc Pers_TypeDoc { get; set; }
        [Display(Name = "Documento")]
        public string Pers_Doc { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime Pers_Birth { get; set; }
        [Display(Name = "Dirección")]
        public string Pers_Dir { get; set; }
        [Display(Name = "Celular")]
        public string Pers_Tel1 { get; set; }
        [Display(Name = "Telefono")]
        public string Pers_Tel2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime Pers_Ingreso { get; set; }
        [Display(Name = "Total de Puntos")]
        public int Pers_TotalPoints { get; set; }
        [Display(Name = "Ubicación")]
        public int Ubic_Id { get; set; }
        [Display(Name = "ROL")]
        public Roles Rolp_Id { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Nombre de Usuario")]
        [Required(ErrorMessage = "Se Debe Contar con un Nombre de Usuario")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Se Debe Contar con un Rol de Usuario")]
        [Display(Name = "Rol")]
        public Roles Role { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Se Debe Contar con un Nombre")]
        public string FirstName { get; set; }
        [Display(Name = "Apellidos")]
        public string Pers_Lstn1 { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string Pers_Lstn2 { get; set; }
        [Display(Name = "Tipo de Documento")]
        public TipoDoc Pers_TypeDoc { get; set; }
        [Display(Name = "Documento")]
        public string Pers_Doc { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime Pers_Birth { get; set; }
        [Display(Name = "Dirección")]
        public string Pers_Dir { get; set; }
        [Display(Name = "Celular")]
        public string Pers_Tel1 { get; set; }
        [Display(Name = "Telefono")]
        public string Pers_Tel2 { get; set; }
        [Display(Name = "Area")]
        [Required(ErrorMessage = "Se Debe Contar con una Area")]
        public int AreaId { get; set; }
        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "Se Debe Contar con una Ciudad")]
        public int CityId { get; set; }
        [Display(Name = "Ubicación")]
        [Required(ErrorMessage = "Se Debe Contar con una Ubicación")]
        public int LocationId { get; set; }
        public string SearchUser { get; set; }
        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }
}
