using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiFilterCtrl : GuiControl
   {
      
      public GuiFilterCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiFilterCtrlCreateInstance());
      }

      public GuiFilterCtrl(uint pId) : base(pId)
      {
      }

      public GuiFilterCtrl(string pName) : base(pName)
      {
      }

      public GuiFilterCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiFilterCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiFilterCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern int GuiFilterCtrlGetControlPoints(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiFilterCtrlSetControlPoints(IntPtr ctrl, int points);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiFilterCtrlCreateInstance();

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string GuiFilterCtrlGetValue(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiFilterCtrlSetValue(IntPtr ctrl, int argc, string[] argv);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiFilterCtrlIdentity(IntPtr ctrl);
      }
      
      #endregion

      #region Properties

      public int ControlPoints
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiFilterCtrlGetControlPoints(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFilterCtrlSetControlPoints(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public string GetValue()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiFilterCtrlGetValue(ObjectPtr->ObjPtr);
      }

      public void SetValue(int argc, string[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFilterCtrlSetValue(ObjectPtr->ObjPtr, argc, argv);
      }

      public void Identity()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFilterCtrlIdentity(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}