using System;

public class Agent
{

    public string CodeName;
    private int ClearanceLevel;


    public Agent(string CodeName, int ClearanceLevel)
    {
        this.CodeName = CodeName;
        this.ClearanceLevel = ClearanceLevel;
    }

    public void Report()
    {

        Console.WriteLine($"Agent {CodeName} reporting. Clearance Level: {ClearanceLevel}");
    }

    public void GetClearanceLevel()
    {
        return ClearanceLevel;
    }


    public void SetClearanceLevel(int level)
    {
        if (level > 5 || level < 1)
        {
            Console.WriteLine("Error");
        }
        
        else
        {
            int ClearanceLevel = level;
        }
    }




}
