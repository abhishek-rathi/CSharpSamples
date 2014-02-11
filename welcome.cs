using System;

class welcome
{
   static void Main(string[] args)
     {    
         Console.WriteLine("\nWelcome. FM {0} LN {1}",args[0],args[1]);
         Console.Write("Currrent Time ");
         string time = Console.ReadLine();
         Console.WriteLine("Time to sleep {0}",Int32.Parse(time)+4);
         
         if (time == "4")
         	Console.WriteLine ("Passed IF");
         else if (args[0] == "a")
         	Console.WriteLine ("Passed ELSE IF");
         else
         	Console.WriteLine ("Passed ELSE");

         Console.WriteLine("...");
         
	 int myInt = Int32.Parse(time);
         switch (myInt)
         {
         	case 4:
         		Console.WriteLine("{0} confirmed again",time);
         		break;
         	default:
         		Console.WriteLine("Exit Switch");
         		break;
         }
         
         Console.WriteLine("...");
         
         while (myInt < 4)
         {
         	Console.WriteLine ("While W{0} ",myInt);
         	myInt++;
         }
         
         Console.WriteLine("...");
         
         for (int i=1;i < myInt; i++)
         {
         	Console.WriteLine ("For F{0} ",i);
         }
         
         Console.WriteLine("...");
         
         foreach (string arr in args)
         {
         	Console.WriteLine ("{0}",arr);
         }
         
         welcome W =  new welcome();
     	 W.fmthd();
     }    

     void fmthd()
     {
         Console.WriteLine ("\nfmthd - type bye");
         string fmmthdin = Console.ReadLine ();
         Console.WriteLine ("{0}",fmmthdin);
     }

}