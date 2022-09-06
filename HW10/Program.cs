namespace HW10;

delegate void MyDel(string?key);
class Program
{
    static void WorkDoc(string?key)
    {

        List<DocumentProgram> docs = new List<DocumentProgram>();
        switch (key)
        {
            case "basic":
               docs.Add(new DocumentProgram());
                new DocumentProgram().OpenDocument();
                new DocumentProgram().EditDocument();
                new DocumentProgram().SaveDocument();
                break;
            case "pro":
                docs.Add(new ProDocumentProgram());
                new ProDocumentProgram().OpenDocument();
                new ProDocumentProgram().EditDocument();
                new ProDocumentProgram().SaveDocument();

                break;
            case "expert":
                docs.Add(new ExpertDocument());
                new ExpertDocument().OpenDocument();
                new ExpertDocument().EditDocument();
                new ExpertDocument().SaveDocument();
                break;

            default:
                Console.WriteLine("Incorrect input");
                break;
        }

       
    }
    static void Main()
    {
        MyDel myDel = null;
        Console.WriteLine("Welcome to Document editor...");
        Thread.Sleep(1000);
        Console.Clear();
        string key;
        myDel += WorkDoc;
        while (true)
        {
            Console.WriteLine("Enter the key: ");
            key = Console.ReadLine();

            myDel.Invoke(key);

            
        }


    }
}
