﻿using System.Diagnostics;
using Azure.Functions.Cli.Interfaces;

namespace Azure.Functions.Cli.Common
{
    internal class ProcessInfo : IProcessInfo
    {
        private readonly Process _process;

        public int Id { get { return _process.Id; } }

        public string FileName { get { return _process.MainModule.FileName; } }

        public string ProcessName { get { return _process.ProcessName; } }

        public ProcessInfo(Process process)
        {
            _process = process;
        }

        public void Kill()
        {
            _process.Kill();
        }
    }
}
