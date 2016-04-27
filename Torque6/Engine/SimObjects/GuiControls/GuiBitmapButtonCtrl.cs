using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiBitmapButtonCtrl : GuiButtonCtrl
   {
      
      public GuiBitmapButtonCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiBitmapButtonCtrlCreateInstance());
      }

      public GuiBitmapButtonCtrl(uint pId) : base(pId)
      {
      }

      public GuiBitmapButtonCtrl(string pName) : base(pName)
      {
      }

      public GuiBitmapButtonCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBitmapButtonCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiBitmapButtonCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern bool GuiBitmapButtonCtrlGetIsLegacyVersion(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiBitmapButtonCtrlSetIsLegacyVersion(IntPtr ctrl, bool isLegacy);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiBitmapButtonCtrlGetBitmap(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiBitmapButtonCtrlSetBitmap(IntPtr ctrl, string bitmap);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiBitmapButtonCtrlGetBitmapNormal(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiBitmapButtonCtrlSetBitmapNormal(IntPtr ctrl, string bitmap);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiBitmapButtonCtrlGetBitmapHilight(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiBitmapButtonCtrlSetBitmapHilight(IntPtr ctrl, string bitmap);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiBitmapButtonCtrlGetBitmapDepressed(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiBitmapButtonCtrlSetBitmapDepressed(IntPtr ctrl, string bitmap);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiBitmapButtonCtrlGetBitmapInactive(IntPtr ctrl);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void GuiBitmapButtonCtrlSetBitmapInactive(IntPtr ctrl, string bitmap);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr GuiBitmapButtonCtrlCreateInstance();
      }
      
      #endregion

      #region Properties

      public bool IsLegacyVersion
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiBitmapButtonCtrlGetIsLegacyVersion(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetIsLegacyVersion(ObjectPtr->ObjPtr, value);
         }
      }
      public string Bitmap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmap(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmap(ObjectPtr->ObjPtr, value);
         }
      }
      public string BitmapNormal
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmapNormal(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmapNormal(ObjectPtr->ObjPtr, value);
         }
      }
      public string BitmapHilight
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmapHilight(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmapHilight(ObjectPtr->ObjPtr, value);
         }
      }
      public string BitmapDepressed
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmapDepressed(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmapDepressed(ObjectPtr->ObjPtr, value);
         }
      }
      public string BitmapInactive
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiBitmapButtonCtrlGetBitmapInactive(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiBitmapButtonCtrlSetBitmapInactive(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}