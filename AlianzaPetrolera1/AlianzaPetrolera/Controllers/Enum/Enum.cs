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
        Admin,
        Entrenador_Lider,
        Entrenador,
        Padre,
        Madre,
        Estudiante
    }
}