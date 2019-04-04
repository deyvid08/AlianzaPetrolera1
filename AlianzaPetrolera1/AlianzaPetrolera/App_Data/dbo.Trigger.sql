CREATE TRIGGER [dbo].[InscripcionsA]
  ON [dbo].[Personas] 
  AFTER INSERT 
AS 
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

   -- Insert statements for trigger here
INSERT INTO [dbo].[Inscripcions](Pers_Doc,Insc_NomEst,Insc_ApeEst,Insc_DocEst,Insc_FechInsc)
SELECT MAX(Pers_Cod),Pers_Nom,Pers_Lstn1,Pers_Doc,Pers_Ingreso FROM dbo.Personas GROUP BY Pers_Nom,Pers_Lstn1,Pers_Doc,Pers_Ingreso

END

