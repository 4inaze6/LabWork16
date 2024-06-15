using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class InfoEventArgs
    {
        public string PropertyName { get; set; }

        public string ErrorText { get; set; }

        public DateTime EditionDate {  get; set; }
        
        public InfoEventArgs(string propertyName, string errorText, DateTime editionDate)
        {
            PropertyName = propertyName;
            ErrorText = errorText;
            EditionDate = editionDate;
        }
    }
}
