using System;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Utility;

namespace Torque6.Engine.Namespaces
{
   public static unsafe class Gui
   {
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern bool Gui_CreateCanvas(string title);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Gui_SetCanvasTitle(string windowTitle);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void Gui_ScreenShot(string file, string format);
      }

      #endregion
      
      #region Functions

      public static bool CreateCanvas(string title)
      {
         return InternalUnsafeMethods.Gui_CreateCanvas(title);
      }

      public static void SetCanvasTitle(string windowTitle)
      {
         InternalUnsafeMethods.Gui_SetCanvasTitle(windowTitle);
      }

      public static void ScreenShot(string file, string format)
      {
         InternalUnsafeMethods.Gui_ScreenShot(file, format);
      }      

      #endregion
   }
}