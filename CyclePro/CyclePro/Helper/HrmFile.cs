using System;
using System.Linq;
using System.Text;
using CyclePro.Data;

namespace CyclePro.Helper
{
    public class HrmFile
    {
        private readonly Hrm _hrm;
        private StringBuilder _rawHrm;

        private const String Nl = "\r\n";
        private const String Tb = "\t";


        public HrmFile(Hrm hrm)
        {
            _hrm = hrm;
            Create();
        }

        public String HrmString()
        {
            return _rawHrm.ToString();
        }

        private void Create()
        {
            _rawHrm = new StringBuilder();

            GenerateParams();
            GenerateUnusedFields();
            GenerateHrmData();
        }

        private int GetModelNumber(string name)
        {
            var value =
                _hrm.Parameters
                    .ModelName
                    .FirstOrDefault(m => m.Value == name);

            return value.Key;
        }

        private void GenerateParams()
        {
            var sb = new StringBuilder();
            sb.Append("[Params]" + Nl);
            sb.Append("Version=" + _hrm.Parameters.Version + Nl);
            sb.Append("Monitor=" + GetModelNumber(_hrm.Parameters.Monitor) + Nl);
            sb.Append("SMode=" + _hrm.Parameters.SMode + Nl);
            sb.Append("Date=" + _hrm.Parameters.StartDateTime.ToString("yyyyMMdd") + Nl);
            sb.Append("StartTime=" + _hrm.Parameters.StartDateTime.ToString("T") + Nl);

            sb.Append("Length=" + _hrm.Parameters.Length + Nl);
            sb.Append("Interval=" + _hrm.Parameters.Interval.Seconds + Nl);

            sb.Append("Upper1=" + _hrm.Parameters.Upper1 + Nl);
            sb.Append("Lower1=" + _hrm.Parameters.Lower1 + Nl);
            sb.Append("Upper2=" + _hrm.Parameters.Upper2 + Nl);
            sb.Append("Lower2=" + _hrm.Parameters.Lower2 + Nl);
            sb.Append("Upper3=" + _hrm.Parameters.Upper3 + Nl);
            sb.Append("Lower3=" + _hrm.Parameters.Lower3 + Nl);
            sb.Append("Timer1=" + _hrm.Parameters.Timer1 + Nl);
            sb.Append("Timer2=" + _hrm.Parameters.Timer2 + Nl);
            sb.Append("Timer3=" + _hrm.Parameters.Timer3 + Nl);

            sb.Append("ActiveLimit=" + _hrm.Parameters.ActiveLimit + Nl);
            sb.Append("MaxHR=" + _hrm.Parameters.MaxHr + Nl);
            sb.Append("RestHR=" + _hrm.Parameters.RestHr + Nl);
            sb.Append("StartDelay=" + _hrm.Parameters.StartDelay + Nl);
            sb.Append("VO2max=" + _hrm.Parameters.Vo2Max + Nl);
            sb.Append("Weight=" + _hrm.Parameters.Weight + Nl);

            _rawHrm.Append(Nl + sb);
        }

        private void GenerateUnusedFields()
        {
            var sb = new StringBuilder();

            sb.Append(Nl + "[Note]" + Nl + Nl);
            sb.Append("[IntTimes]" + Nl + Nl);
            sb.Append("[IntNotes]" + Nl + Nl);
            sb.Append("[ExtraData]" + Nl + Nl);
            sb.Append("[LapNames]" + Nl + Nl);
            sb.Append("[Summary-123]" + Nl + Nl);
            sb.Append("[Summary-TH]" + Nl + Nl);
            sb.Append("[HRZones]" + Nl + Nl);
            sb.Append("[SwapTimes]" + Nl + Nl);
            sb.Append("[Trip]" + Nl + Nl);

            _rawHrm.Append(sb);
        }

        private void GenerateHrmData()
        {
            var sb = new StringBuilder();
            sb.Append("//n header" + Nl);
            sb.Append("[HRData]" + Nl);

            foreach (var row in _hrm.Data)
            {

                sb.Append(row.Hr + Tb);
                

                if (_hrm.Features.Speed)
                {
                    var speed = Math.Round(row.Speed * 10);
                    sb.Append(speed + Tb);
                }

                if (_hrm.Features.Cadence)
                {
                    sb.Append(row.Cadence + Tb);
                }

                if (_hrm.Features.Altitude)
                {
                    sb.Append(row.Altitude + Tb);
                }

                if (_hrm.Features.Power)
                {
                    sb.Append(row.Power + Tb);
                    sb.Append(row.Pressure + Tb);
                }

                sb.Append(Nl);
            }

            _rawHrm.Append(sb);

        }
    }
}