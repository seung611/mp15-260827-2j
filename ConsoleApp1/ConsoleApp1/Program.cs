using System;

public class Program  
{  
    public static void Main()  
    {  
        Console.WriteLine("=== 2조 팀원 소개 ===");  
        IntroAsteYume();
        // 여기에 팀원 소개 호출을 한 줄씩 추가합니다

        IntroRocket22();
        IntroSeung611();


        Console.WriteLine("=== 소개 끝 ===");  
    }

    public static void IntroAsteYume()
    {
        Console.WriteLine("김하늘 / 타자가 빠릅니다");
    } 

    // 여기에 팀원 소개 메서드를 하나씩 추가합니다  
    public static void IntroRocket22()
    {
        Console.WriteLine("안녕하세요 Rocket22 입니다.");
    }
    public static void IntroSeung611()
    {
        Console.WriteLine("류승민 / 안녕하세요");
    }
}
