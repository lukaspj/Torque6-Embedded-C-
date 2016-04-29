using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiInspectorGroup : GuiRolloutCtrl
   {
      
      public GuiInspectorGroup()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiInspectorGroupCreateInstance());
      }

      public GuiInspectorGroup(uint pId) : base(pId)
      {
      }

      public GuiInspectorGroup(string pName) : base(pName)
      {
      }

      public GuiInspectorGroup(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorGroup(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiInspectorGroup(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorGroupCreateInstance();
         private static _GuiInspectorGroupCreateInstance _GuiInspectorGroupCreateInstanceFunc;
         internal static IntPtr GuiInspectorGroupCreateInstance()
         {
            if (_GuiInspectorGroupCreateInstanceFunc == null)
            {
               _GuiInspectorGroupCreateInstanceFunc =
                  (_GuiInspectorGroupCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiInspectorGroupCreateInstance"), typeof(_GuiInspectorGroupCreateInstance));
            }

            return _GuiInspectorGroupCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}