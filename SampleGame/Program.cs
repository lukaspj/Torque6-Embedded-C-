namespace SampleGame
{
   class Program
   {
      static void Main(string[] args)
      {
         Torque6.Interop.Torque6.Libraries libraries = new Torque6.Interop.Torque6.Libraries
         {
            Windows32bit = "Torque6_DEBUG.dll",
            Windows64bit = "Torque6_DEBUG.dll",
            Linux32bit = "Torque6_DEBUG.so",
            Linux64bit = "Torque6_DEBUG.so"
         };
         Torque6.Interop.Torque6.Initialize(args, libraries);
      }
   }
}
