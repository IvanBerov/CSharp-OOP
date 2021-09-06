using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();

            string result = spy.CollectGettersAndSetters("Stealer.Hacker");

                //= spy.RevealPrivateMethods("Stealer.Hacker");
                // = spy.StealFieldInfo("Stealer.Hacker", "username", "password"); //1.Stealer
                // = spy.AnalyzeAcessModifiers("Stealer.Hacker");                  //2.High Quality Mistakes

            Console.WriteLine(result);


        }
    }
}
