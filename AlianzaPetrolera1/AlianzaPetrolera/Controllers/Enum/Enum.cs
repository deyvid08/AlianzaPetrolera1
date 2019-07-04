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
        Selecione=0,
        Padre,
        Admin,
        Entrenador,
        SuperAdmin,
        AdminJefe

    }
    public enum RolHijo
    {
        Estudiante
    }
    public enum Roles_Admin
    {
        Admin = 2,
        Entrenador_Lider,
        Entrenador,
        SuperAdmin,
        AdminJefe
        
    }
    public enum Periodo
    {
        Semestre_Uno,
        Semestre_Dos
    }
    public enum EstadoMatricula
    {
        Inactivo,
        Activo
        
    }
    public enum ReciEstado
    {
        Pago,
        No_Pago
    }
    public enum Ubic
    {
        Barrancabermeja,
        Barranquito,
        La_Cira,
        Barranquita,
        Bogotá,
        Medellin
    }
}