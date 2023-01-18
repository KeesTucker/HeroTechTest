using HeroTechTest.Enums;

namespace HeroTechTest.Models;

public struct StudentData
{
    public Guid HeroId;
    public string Name;
    public DateTime Dob;
    public Gender Gender;
    public bool CurrentStudent;
    public string Addr1;
    public string Addr2;
    public string Addr3;
    public string Addr4;
    public string[] Ethnicities;
    public string Cg1Phone;
    public string Cg1Sms;
    public string Cg2Phone;
    public string Cg2Sms;
}