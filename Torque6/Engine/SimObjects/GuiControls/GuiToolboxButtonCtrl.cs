using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiToolboxButtonCtrl : GuiButtonCtrl
   {
      
      public GuiToolboxButtonCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiToolboxButtonCtrlCreateInstance());
      }

      public GuiToolboxButtonCtrl(uint pId) : base(pId)
      {
      }

      public GuiToolboxButtonCtrl(string pName) : base(pName)
      {
      }

      public GuiToolboxButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiToolboxButtonCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiToolboxButtonCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiToolboxButtonCtrlGetNormalBitmap(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiToolboxButtonCtrlSetNormalBitmap(IntPtr ctrl, string bitmap);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiToolboxButtonCtrlGetLoweredBitmap(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiToolboxButtonCtrlSetLoweredBitmap(IntPtr ctrl, string bitmap);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiToolboxButtonCtrlGetHoverBitmap(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiToolboxButtonCtrlSetHoverBitmap(IntPtr ctrl, string bitmap);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiToolboxButtonCtrlCreateInstance();
      }
      
      #endregion

      #region Properties

      public string NormalBitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiToolboxButtonCtrlGetNormalBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiToolboxButtonCtrlSetNormalBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      public string LoweredBitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiToolboxButtonCtrlGetLoweredBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiToolboxButtonCtrlSetLoweredBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      public string HoverBitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiToolboxButtonCtrlGetHoverBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiToolboxButtonCtrlSetHoverBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}