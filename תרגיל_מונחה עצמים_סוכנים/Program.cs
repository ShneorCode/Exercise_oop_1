internal class Program


{

    static void Main(string[] args)
    {


        Agent siri = new Agent("avi", 4);

        siri.Report();

        Mission m1 = new Mission("Operation Gideon Chariots", "Gaza", siri);
        m1.Brief();



    }





}