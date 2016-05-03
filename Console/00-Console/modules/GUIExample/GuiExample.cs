using Torque6.Engine.Namespaces;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.GuiControls;
using Torque6.Interop;

namespace ConsoleExample.modules.GUIExample
{
   [ConsoleClass]
   class GUIExample : SimSet
   {
      public void create()
      {
         ModuleDefinition ConsoleModule = new ModuleDefinition("Console");
         //Todo format should be optional
         ConsoleModule.Add(Engine.TamlRead("modules/GUIExample/1/gui/ExampleDialog.gui.taml", "xml"));
         GuiCanvas Canvas = new GuiCanvas("Canvas");
         //Todo layer should be optional
         Canvas.PushDialog(new GuiControl("ExampleDialog"), 0);
      }

      public void destroy()
      {
         //
      }
   }
}
