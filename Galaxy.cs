using System;

namespace Phone
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}

        public virtual string Ring()
        {
            return $"... {Ringtone} ...";
        }

        public virtual string Unlock()
        {
            return $"Galaxy {VersionNumber} unlocked with fingerprint scanner";
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("");
            string tabs = "#########################";
            Console.WriteLine(tabs);
            Console.WriteLine($"Galaxy {VersionNumber}");
            Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ringtone: {Ringtone}");
            Console.WriteLine(tabs);
            Console.WriteLine("");
        }
    }
}