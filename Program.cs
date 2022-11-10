using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(numero:"129999999", modelo:"lumia",imei:"1231313",memoria:64);

nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Clash of clans");
Iphone iphone = new Iphone(numero:"999999", modelo:"S5", imei:"12938123",memoria:32);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("zap zap");