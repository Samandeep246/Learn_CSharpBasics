static class QuestLogic
{
   
    public static bool CanFastAttack(bool knightIsAwake)=>(knightIsAwake==true)? false :true;   
   

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)=>(knightIsAwake||archerIsAwake)||(prisonerIsAwake);
   
 
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(archerIsAwake==false && prisonerIsAwake==true )
        return true; 
        else return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
{
    return (petDogIsPresent && !archerIsAwake) ||
           (!petDogIsPresent && !knightIsAwake && !archerIsAwake && prisonerIsAwake);
}
}
