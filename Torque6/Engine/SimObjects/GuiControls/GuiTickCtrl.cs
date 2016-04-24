using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiTickCtrl : GuiControl
   {
      
      public GuiTickCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiTickCtrlCreateInstance());
      }

      public GuiTickCtrl(uint pId) : base(pId)
      {
      }

      public GuiTickCtrl(string pName) : base(pName)
      {
      }

      public GuiTickCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTickCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTickCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiTickCtrlCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiTickCtrlSetProcessTicks(IntPtr ctrl, bool tick);
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void SetProcessTicks(bool tick)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTickCtrlSetProcessTicks(ObjectPtr->ObjPtr, tick);
      }
      
      #endregion

      
   }
}