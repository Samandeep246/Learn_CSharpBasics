class Lasagna
{
   public int ActualCookingMinutes= 40;
    
    // TODO: define the 'ExpectedMinutesInOven()' method
   public int ExpectedMinutesInOven( )=>40; 
   
     // TODO: define the 'RemainingMinutesInOven()' method
    public int  RemainingMinutesInOven(int ActualMinInOven)=>ActualCookingMinutes-ActualMinInOven;
  
     // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int noOfLayers)=> (2 * noOfLayers);
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int noOfLayers, int ActualMinInOven )
    {
        int calculate;    
        calculate= (ActualMinInOven)+(noOfLayers*2);
        return calculate;
    }  
}
