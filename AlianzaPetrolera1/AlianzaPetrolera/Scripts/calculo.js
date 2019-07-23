function sumar() {

    var matricula = $(Matricula).val();
    var poliza = $(Poliza).val();
    var uniforme = $(Uniforme).val();
    var mensualidad = $(Mensualidad).val();
    var descmatri = $(DescMatri).val();
    var descpoli = $(DescPoli).val();
    var descunif = $(DescUnif).val();
    var descmensu = $(DescMensu).val();
    var total = 0;

    var calmatri
    var finmatri
    var calpoli
    var finpoli
    var calunif
    var finunif
    var calmensu
    var finmensu

    calmatri = ((matricula * descmatri) / 100);
    finmatri = (matricula - calmatri);

    calpoli = ((poliza * descpoli) / 100);
    finpoli = (poliza - calpoli);

    calunif = ((uniforme * descunif) / 100);
    finunif = (uniforme - calunif);

    calmensu = ((mensualidad * descmensu) / 100);
    finmensu = (mensualidad - calmensu);

    total = finmatri + finpoli + finunif + finmensu;


    $(Total).val(total);
    $(CosMatri).val(finmatri);
    $(CosPoli).val(finpoli);
    $(CosUnif).val(finunif);
    $(CosMensu).val(finmensu);
}