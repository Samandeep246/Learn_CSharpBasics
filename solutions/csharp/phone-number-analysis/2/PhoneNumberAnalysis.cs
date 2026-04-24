public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] parts=phoneNumber.Split('-');
        bool IsNewYork=false;
        bool IsFake = false;
        string LocalNumber=parts[2];        
        if(parts[0]=="212") IsNewYork=true;
        if(parts[1]=="555") IsFake=true;
        return (IsNewYork,IsFake,LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)=>(phoneNumberInfo.IsFake);
    
}
