using System;
using abbytest.two;

namespace master
{
	class master
	{
		public master()
		{
			Console.WriteLine ("Lets Get Started \n\n");
		}
	}
}

namespace abbytest.one
{
	class welcome : master.master
	{
	   
	   static welcome ()
	   {
	   	welcome w = new welcome();
	   	Console.WriteLine ("Welcome Called!");	   	
	   }
	   
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

		 for (int i=1;i < myInt & i < 5; i++)
		 {
			Console.WriteLine ("For F{0} ",i);
		 }

		 Console.WriteLine("...");

		 foreach (string arr in args)
		 {
			Console.WriteLine ("{0}",arr);
		 }

		 outmthds O = new outmthds("a","b");
		 O.fmthd();
	   }
	   
	}
}

namespace abbytest.two
{
	class outmthds
	{
	     public void fmthd()
	     {
		 Console.Write ("\nfmthd - type bye: ");
		 string fmmthdin = Console.ReadLine ();
		 if (fmmthdin == "bye")
		 	Console.WriteLine ("Ok!");
		 else
		 	Console.WriteLine ("{0}",fmmthdin);
	     }
	     
	     public outmthds (string a, string b)
	     {
	     	   	if (a == "")
	     	   		a = "NO";
	     	   	if (b == "")
	     	   		b = "VALUE";
	     	   	Console.WriteLine("Call from Main - {0},{1}",a,b);
	     }
	}
}
