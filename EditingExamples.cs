using System;

public class EditingExamples
{
    public enum EnumExample
    {
        A,
        B,
        C,
        D
    }

    // public string ExampleA(EnumExample)

    public static string EnumToSmileyFace(EnumExample enumExample)
    {
        // We want the stringized enum and a smileyface!
        
        return ":c";
    }
}



// public string EnumToSmileyFaceBackup(EnumExample enumExample)
// {
//     switch(enumExample)
//     {
//         case EnumExample.A: return "A :D";
//         case EnumExample.B: return "B :D";
//         case EnumExample.C: return "C :D";
//         case EnumExample.D: return "D :D";
//     }
    
//     return ":c";
// }