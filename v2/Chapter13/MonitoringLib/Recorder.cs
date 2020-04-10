using System;
using System.Diagnostics;
using static System.Console;
using static System.Diagnostics.Process;

namespace MonitoringLib
{
	public static class Recorder
	{
		static Stopwatch timer = new Stopwatch ();
		private static long _bytesPhysicalBefore;
		private static long _bytesVirtualBefore;

		public static void Start()
		{
			GC.Collect ();
			GC.WaitForPendingFinalizers ();
			GC.Collect();
			_bytesPhysicalBefore = GetCurrentProcess ().WorkingSet64;
			_bytesVirtualBefore = GetCurrentProcess ().VirtualMemorySize64;
			timer.Restart ();
		}

		public static void Stop()
		{
			timer.Stop ();
			long bytesPhysicalAfter = GetCurrentProcess ().WorkingSet64;
			long bytesVirtualAfter = GetCurrentProcess ().VirtualMemorySize64;
			WriteLine("Stopped recording.");
			WriteLine($"{bytesPhysicalAfter - _bytesPhysicalBefore:N0} physical bytes used.");
			WriteLine($"{bytesVirtualAfter - _bytesVirtualBefore:N0} virtual bytes used.");
			WriteLine($"{timer.Elapsed} time span elapsed");
			WriteLine($"{timer.ElapsedMilliseconds:N0} total ms elapsed");
		}
	}
}