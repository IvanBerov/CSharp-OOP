using System;
using System.IO;
using Logger.Enums;
using Logger.Layouts;
using Logger.Loggers;

namespace Logger.Appenders
{
    public class FileAppender : Appender
    {
        private ILogFile logFile;
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string date, ReportLevel reportLevel, string message)
        {
            if (!this.CanAppend(reportLevel))
            {
                return;
            }

            this.MessagesCount += 1;

            string content = string.Format(this.layout.Template, date, reportLevel, message) + Environment.NewLine;

            this.logFile.Write(content);
        }

        public override string ToString()
        {
            return base.ToString() + $", File size: {this.logFile.Size}";
        }
    }
}
