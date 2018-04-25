using System;
using System.Collections.Generic;
using System.Windows;
using Uniconta.API.Plugin;
using Uniconta.API.Service;
using Uniconta.Common;

namespace PrePostEventPlugin
{
    public class PrePostEventPlugin : IPluginBase
    {
        // Fields
        private string errorDescription;

        public string Name { get { return "PrePostEventPlugin"; } }

        public void Intialize()
        {
            errorDescription = "No Error Set";
        }

        public ErrorCodes Execute(UnicontaBaseEntity master, UnicontaBaseEntity currentRow, IEnumerable<UnicontaBaseEntity> source, string command, string args)
        {
            MessageBox.Show($"Command: {command}");
            return ErrorCodes.Succes;
        }

        public string[] GetDependentAssembliesName()
        {
            return new string[] { };
        }

        public string GetErrorDescription()
        {
            return errorDescription;
        }


        public void SetAPI(BaseAPI api)
        {
        }

        public void SetMaster(List<UnicontaBaseEntity> masters)
        {
        }

        public event EventHandler OnExecute;
    }
}
