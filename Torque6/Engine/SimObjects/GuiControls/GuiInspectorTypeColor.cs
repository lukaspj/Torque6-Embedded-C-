using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorTypeColor : GuiInspectorField
   {
      
      public GuiInspectorTypeColor()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorTypeColorCreateInstance());
      }

      public GuiInspectorTypeColor(uint pId) : base(pId)
      {
      }

      public GuiInspectorTypeColor(string pName) : base(pName)
      {
      }

      public GuiInspectorTypeColor(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeColor(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorTypeColor(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeColorCreateInstance();
         private static _GuiInspectorTypeColorCreateInstance _GuiInspectorTypeColorCreateInstanceFunc;
         internal static IntPtr GuiInspectorTypeColorCreateInstance()
         {
            if (_GuiInspectorTypeColorCreateInstanceFunc == null)
            {
               _GuiInspectorTypeColorCreateInstanceFunc =
                  (_GuiInspectorTypeColorCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorTypeColorCreateInstance"), typeof(_GuiInspectorTypeColorCreateInstance));
            }

            return _GuiInspectorTypeColorCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}