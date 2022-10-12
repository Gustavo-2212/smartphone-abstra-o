using SmartPhone.models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "15-9636", modelo: "X9", imei: "12112", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("YouTube");

Console.WriteLine("\nSmartphone IPhone:");
Smartphone iphone = new IPhone(numero: "15-5556", modelo: "a-1", imei: "12696", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
