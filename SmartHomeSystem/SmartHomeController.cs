using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        private List<ISwitchable> allDevices = new List<ISwitchable>();
        private List<IEnergyConsumer> energyDevices = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            allDevices.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevices.Add(device);
        }

        public void TurnAllOn()
        {
            foreach (var device in allDevices)
                device.TurnOn();
        }

        public void TurnAllOff()
        {
            foreach (var device in allDevices)
                device.TurnOff();
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"\nЗвіт про споживання енергії за {hours} год:");
            double total = 0;

            foreach (var dev in energyDevices)
            {
                double usage = dev.GetEnergyUsage(hours);
                total += usage;
                Console.WriteLine($"{dev.DeviceName}: {usage:F2} кВт·год (потужність: {dev.PowerConsumption} Вт)");
            }

            Console.WriteLine($"Загальне споживання: {total:F2} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {total * 4:F2} грн\n");
        }
    }
}
