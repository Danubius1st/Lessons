using System;

namespace Lesson04
{
    public class AquosCommand
    {
        protected const int CommandMaxLength = 4;
        protected const int ParamMaxLength = 4;

        public string Command { get; set; }
        public string Parameter { get; set; }

        //public AquosCommand(string command, string parameters = null)
        private AquosCommand(string command, string parameters = null)
        {
            if (string.IsNullOrEmpty(command))
            {
                throw new ArgumentNullException("command");
            }

            command = command.Trim();

            if (command.Length > CommandMaxLength)
            {
                throw new ArgumentException("Command cannot be more than four characters.");
            }

            if (string.IsNullOrEmpty(parameters))
            {
                parameters = string.Empty;
            }

            parameters = parameters.Trim();

            if (parameters.Length > ParamMaxLength)
            {
                throw new ArgumentException("Command parameters cannot be more than four characters.");
            }

            Command = command;
            Parameter = parameters.PadRight(ParamMaxLength);
        }

        //public AquosCommand(string command, int value) : this(command, Convert.ToString(value))
        //{

        //}

        //public AquosCommand(string command, PowerSetting setting) : this(command, (int)setting)
        //{

        //}

        public static AquosCommand Volume(int value)
        {
            return new AquosCommand("VOLM", Convert.ToString(value));
        }

        public static AquosCommand Power(PowerSetting setting)
        {
            return new AquosCommand("POWR", Convert.ToString((int) setting));
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Command, Parameter);
        }
    }
}
