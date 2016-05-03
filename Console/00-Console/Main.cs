using System;
using System.IO;
using System.Reflection;
using Torque6.Engine.Namespaces;
using Torque6.Engine.SimObjects;
using Torque6.Interop;
using Console = Torque6.Engine.Namespaces.Console;
using Version = Torque6.Engine.Namespaces.Version;

namespace ConsoleExample
{
   class Main
   {
      static ModuleManager ModuleDatabase;
      static AssetManager AssetDatabase;

      [ScriptEntryPoint]
      public static void EntryPoint()
      {
         StartConsoleProject();
      }

      public static void StartConsoleProject()
      {
         // Mandatory initialization, since these can't be set based on the non-existant main.cs
         string CSDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
         Engine.SetMainDotCsDir(CSDir + "\\00-Console");
         Engine.SetCurrentDirectory(CSDir + "\\00-Console");

         // Set log mode.
         Console.SetLogMode(1);

         // Set profiler.
         //Profiler.Enable(true);

         // Controls whether the execution of script files or compiled DSOs are echoed to the console or not.
         // Being able to turn this off means far less spam in the console during typical development.
         Script.SetScriptExecEcho(false);


         // Controls whether all script execution is traced (echoed) to the console or not.
         Script.Trace(false);

         // Sets whether to ignore compiled TorqueScript files (DSOs) or not.
         Globals.SetBool("Scripts::ignoreDSOs", true);

         // The name of the company. Used to form the path to save preferences. Defaults to GarageGames
         // if not specified.
         // The name of the game. Used to form the path to save preferences. Defaults to C++ engine define TORQUE_GAME_NAME
         // if not specified.
         // Appending version string to avoid conflicts with existing versions and other versions.
         Version.SetCompanyAndProduct("GarageGames", "Torque6");

         ModuleDatabase = new ModuleManager("ModuleDatabase");
         AssetDatabase = new AssetManager("AssetDatabase");

         // Make sure they have been created
         if (ModuleDatabase.IsDead())
            throw new Exception("ModuleDatabase not found");
         if (AssetDatabase.IsDead())
            throw new Exception("AssetDatabase not found");

         // Set module database information echo.
         ModuleDatabase.EchoInfo = false;

         // Set asset database information echo.
         AssetDatabase.EchoInfo = false;

         // Set the asset manager to ignore any auto-unload assets.
         // This cases assets to stay in memory unless assets are purged.
         AssetDatabase.IgnoreAutoUnload = true;

         // Scan modules.
         ModuleDatabase.ScanModules("modules");

         // Scan shared modules
         ModuleDatabase.ScanModules("../shared-modules");

         // Load AppCore module.
         ModuleDatabase.LoadExplicit("AppCore");
         ModuleDatabase.LoadExplicit("NetworkCore");

         // Load the modules needed for this example
         ModuleDatabase.LoadExplicit("Console");
         ModuleDatabase.LoadExplicit("GUIExample");
         ModuleDatabase.LoadExplicit("SysGUIExample");
      }

      [ConsoleFunction]
      public static void onExit()
      {
         // Unload the AppCore module.
         ModuleDatabase.UnloadExplicit("AppCore");
      }

      [ConsoleFunction]
      public static void androidBackButton(string val)
      {
         // Quit on button down
         if (val == "1")
            Engine.Quit();
      }
   }
}
