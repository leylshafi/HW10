using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class ProDocumentProgram: DocumentProgram
    {
        //1. Document Opened
        //2. Document Edited(burda override elediyiniz metodu seald edirsiniz)
        //3. Document Saved in doc format, for pdf format buy Expert packet

        public sealed override void EditDocument()
        {
            base.EditDocument();
        }

        public override void SaveDocument() => Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
    }
}
