using System;
using System.Collections.Generic;
using System.Windows;
using Uniconta.API.Plugin;
using Uniconta.API.Service;
using Uniconta.ClientTools.DataModel;
using Uniconta.Common;

namespace ButtonPlugin
{
    public class ButtonPlugin : IPluginBase
    {
        // Fields
        private string errorDescription;

        public string Name { get { return "ButtonPlugin"; } }

        public void Intialize()
        {
            errorDescription = "No Error Set";
        }

        public ErrorCodes Execute(UnicontaBaseEntity master, UnicontaBaseEntity currentRow, IEnumerable<UnicontaBaseEntity> source, string command, string args)
        {
            var debtor = currentRow as DebtorClient;
            if(debtor == null)
            {
                errorDescription = "No row or wrong type selected";
                return ErrorCodes.Exception;
            }

            MessageBox.Show($"Selected Debtor: {debtor.Account}");

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
