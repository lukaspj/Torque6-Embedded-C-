using Torque6.Engine.Namespaces;
using Torque6.Engine.SimObjects;
using Torque6.Interop;

namespace ConsoleExample.modules.SysGUIExample
{
   [ConsoleClass]
   class SysGUIExample : SimSet
   {
      public void create()
      {
         SysGUI.BeginScrollArea("My first SysGUI Dialog!", 5, 5, 200, 200);
         SysGUI.Separator();
         SysGUI.Label("Hello World!");
         SysGUI.CheckBox("Checked!", true);
         SysGUI.CheckBox("Unchecked!", false);
         SysGUI.Button("Click Me.", "");
         SysGUI.TextInput("Put Text: ", "In Here!");
         SysGUI.Separator();
         SysGUI.EndScrollArea();
         SysGUI.SetEnabled(true);
      }

      public void destroy()
      {
         //
      }
   }
}
