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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _Gui_CreateCanvas(string title);
         private static _Gui_CreateCanvas _Gui_CreateCanvasFunc;
         internal static bool Gui_CreateCanvas(string title)
         {
            if (_Gui_CreateCanvasFunc == null)
            {
               _Gui_CreateCanvasFunc =
                  (_Gui_CreateCanvas)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Gui_CreateCanvas"), typeof(_Gui_CreateCanvas));
            }

            return _Gui_CreateCanvasFunc(title);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Gui_SetCanvasTitle(string windowTitle);
         private static _Gui_SetCanvasTitle _Gui_SetCanvasTitleFunc;
         internal static void Gui_SetCanvasTitle(string windowTitle)
         {
            if (_Gui_SetCanvasTitleFunc == null)
            {
               _Gui_SetCanvasTitleFunc =
                  (_Gui_SetCanvasTitle)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Gui_SetCanvasTitle"), typeof(_Gui_SetCanvasTitle));
            }

            _Gui_SetCanvasTitleFunc(windowTitle);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Gui_ScreenShot(string file, string format);
         private static _Gui_ScreenShot _Gui_ScreenShotFunc;
         internal static void Gui_ScreenShot(string file, string format)
         {
            if (_Gui_ScreenShotFunc == null)
            {
               _Gui_ScreenShotFunc =
                  (_Gui_ScreenShot)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "Gui_ScreenShot"), typeof(_Gui_ScreenShot));
            }

            _Gui_ScreenShotFunc(file, format);
         }
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