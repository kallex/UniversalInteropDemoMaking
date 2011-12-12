 

		// Import and using statements go here
		using System;
				public class TestServiceCallerProxy
		{
				public static string TestMethod1(int Number1, int Number2)
		{
			// TODO: Code to call the service to reach (possibly autodiscovered) listener
			// Currently: Manually implemented
			return ManualImplementation.TestMethod1(Number1: Number1, Number2: Number2);
		}
				}
		