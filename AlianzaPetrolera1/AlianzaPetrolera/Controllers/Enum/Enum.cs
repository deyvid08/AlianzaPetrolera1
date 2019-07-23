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
    public enum Tpago
    {
        Modo_de_Pago,
        Efectivo,
        Consignación
    }
    public enum Bank
    {
        Banco,
        Ninguno,
        Bancolombia_Corriente_456_015655_06,
        Banco_de_Bogotá_Ahorros_612_812155_07,
        Avevillas_Corriente_786_913352_08,
    }
}