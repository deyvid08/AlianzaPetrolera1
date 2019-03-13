using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlianzaPetrolera.Controllers.Enum
{
    public enum TipoDoc
    {
        Cedula,
        Cedula_extranjera,
        Tarjeta_de_identidad,
        Tarjeta_de_identidad_extranjera,
        NUIP

    }
    public enum Roles
    {
        Padre=0
    }
    public enum RolHijo
    {
        Estudiante=1
    }
    public enum Roles_Admin
    {
       
        Admin=2,
        Entrenador_Lider,
        Entrenador,
        SuperAdmin
    }
}