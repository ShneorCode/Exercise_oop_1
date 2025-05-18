using System;

public class Mission
{

    private string MissionName;
    private string TargetLocation;
    private Agent AssignedAgent;

    

    public Mission(string MissionName, string TargetLocation, Agent AssignedAgent)
    {
        this.MissionName = MissionName;
        this.TargetLocation = TargetLocation;
        this.AssignedAgent = AssignedAgent;

    }


    public void Brief()
    {
        Console.WriteLine($"Mission: {MissionName}, Target: {TargetLocation}, Agent: {AssignedAgent.CodeName}");
    }



}
