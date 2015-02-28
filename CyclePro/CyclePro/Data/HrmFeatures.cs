namespace CyclePro.Data
{
    
    public class HrmFeatures
    {
        public bool Cadence;
        public bool Speed;
        public bool Altitude;
        public bool Power;
        public bool Pressure;
        public bool Hr;
        public bool Euro;


        public HrmFeatures(string mode)
        {
            switch (mode.Length)
            {
                case 3:
                    Cadence = mode[0] == '0';
                    Altitude = mode[0] == '1';
                    Euro = mode[2] == '0';
                    break;
                case 8:
                case 9:
                default:
                    Speed = mode[0] == '1';
                    Cadence = mode[1] == '1';
                    Altitude = mode[2] == '1';
                    Power = mode[3] == '1';
                    Euro = mode[7] == '0';
                    Pressure = mode[8] == '1';
                    break;
            }
        }
    }
}