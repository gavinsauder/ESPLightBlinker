using System;
using System.Diagnostics;
using System.Threading;
using System.Device.Gpio;

namespace ESPLightBlinker
{
    public class Program
    {
        private static GpioController s_GpioController;

        public static void Main()
        {
            s_GpioController = new GpioController();

            Debug.WriteLine("Hello from nanoFramework!");
            // Following this: https://docs.nanoframework.net/content/getting-started-guides/getting-started-managed.html

            GpioPin led = s_GpioController.OpenPin(4, PinMode.Output);
            led.Write(PinValue.Low);

            while (true)
            {
                led.Toggle();
                Thread.Sleep(125);
                led.Toggle();
                Thread.Sleep(125);
                led.Toggle();
                Thread.Sleep(125);
                led.Toggle();
                Thread.Sleep(525);
            }


        }
    }
}
