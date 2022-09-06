using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class ExpertDocument:ProDocumentProgram
    {
        // 1. Document Opened
        // 2. Document Edited
        // 3. Document Saved in pdf format

        public override void SaveDocument() => Console.WriteLine("Document Saved in pdf format");
    }
}
