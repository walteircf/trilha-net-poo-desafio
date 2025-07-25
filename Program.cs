using System;
using System.Collections.Generic;
using DesafioPOO.Models;

namespace DesafioPOO {
    class Program {
        static void Main (string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "62981019844", modelo: "Lumia 1020", imei: "1111111111111", memoria: 256);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Telegram");

            Console.WriteLine("Smartphone Iphone:");
            Smartphone iphone = new Iphone(numero: "62982127455", modelo: "16 Pro Max", imei: "222222222222", memoria: 512);
            iphone.ReceberLigacao();
            iphone.Ligar();
            iphone.InstalarAplicativo("WhatsApp");

        }
    }
}