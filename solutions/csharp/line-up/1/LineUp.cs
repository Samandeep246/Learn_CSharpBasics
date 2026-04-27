public static class LineUp
{
    public static string Format(string name, int number)
    {
    if (number % 10 == 1 && number % 100 != 11) return $"{name}, you are the {number}st customer we serve today. Thank you!";    
    if (number % 10 == 2 && number % 100 != 12) return $"{name}, you are the {number}nd customer we serve today. Thank you!";  
    if (number % 10 == 3 && number % 100 != 13) return $"{name}, you are the {number}rd customer we serve today. Thank you!";  
    return $"{name}, you are the {number}th customer we serve today. Thank you!";  
    }
}
