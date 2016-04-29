using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiStackControl : GuiControl
   {
      
      public GuiStackControl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiStackControlCreateInstance());
      }

      public GuiStackControl(uint pId) : base(pId)
      {
      }

      public GuiStackControl(string pName) : base(pName)
      {
      }

      public GuiStackControl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiStackControl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiStackControl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiStackControlGetStackingType(IntPtr ctrl);
         private static _GuiStackControlGetStackingType _GuiStackControlGetStackingTypeFunc;
         internal static int GuiStackControlGetStackingType(IntPtr ctrl)
         {
            if (_GuiStackControlGetStackingTypeFunc == null)
            {
               _GuiStackControlGetStackingTypeFunc =
                  (_GuiStackControlGetStackingType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlGetStackingType"), typeof(_GuiStackControlGetStackingType));
            }

            return _GuiStackControlGetStackingTypeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiStackControlSetStackingType(IntPtr ctrl, int type);
         private static _GuiStackControlSetStackingType _GuiStackControlSetStackingTypeFunc;
         internal static void GuiStackControlSetStackingType(IntPtr ctrl, int type)
         {
            if (_GuiStackControlSetStackingTypeFunc == null)
            {
               _GuiStackControlSetStackingTypeFunc =
                  (_GuiStackControlSetStackingType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlSetStackingType"), typeof(_GuiStackControlSetStackingType));
            }

            _GuiStackControlSetStackingTypeFunc(ctrl, type);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiStackControlGetHorizStacking(IntPtr ctrl);
         private static _GuiStackControlGetHorizStacking _GuiStackControlGetHorizStackingFunc;
         internal static int GuiStackControlGetHorizStacking(IntPtr ctrl)
         {
            if (_GuiStackControlGetHorizStackingFunc == null)
            {
               _GuiStackControlGetHorizStackingFunc =
                  (_GuiStackControlGetHorizStacking)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlGetHorizStacking"), typeof(_GuiStackControlGetHorizStacking));
            }

            return _GuiStackControlGetHorizStackingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiStackControlSetHorizStacking(IntPtr ctrl, int type);
         private static _GuiStackControlSetHorizStacking _GuiStackControlSetHorizStackingFunc;
         internal static void GuiStackControlSetHorizStacking(IntPtr ctrl, int type)
         {
            if (_GuiStackControlSetHorizStackingFunc == null)
            {
               _GuiStackControlSetHorizStackingFunc =
                  (_GuiStackControlSetHorizStacking)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlSetHorizStacking"), typeof(_GuiStackControlSetHorizStacking));
            }

            _GuiStackControlSetHorizStackingFunc(ctrl, type);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiStackControlGetVertStacking(IntPtr ctrl);
         private static _GuiStackControlGetVertStacking _GuiStackControlGetVertStackingFunc;
         internal static int GuiStackControlGetVertStacking(IntPtr ctrl)
         {
            if (_GuiStackControlGetVertStackingFunc == null)
            {
               _GuiStackControlGetVertStackingFunc =
                  (_GuiStackControlGetVertStacking)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlGetVertStacking"), typeof(_GuiStackControlGetVertStacking));
            }

            return _GuiStackControlGetVertStackingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiStackControlSetVertStacking(IntPtr ctrl, int type);
         private static _GuiStackControlSetVertStacking _GuiStackControlSetVertStackingFunc;
         internal static void GuiStackControlSetVertStacking(IntPtr ctrl, int type)
         {
            if (_GuiStackControlSetVertStackingFunc == null)
            {
               _GuiStackControlSetVertStackingFunc =
                  (_GuiStackControlSetVertStacking)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlSetVertStacking"), typeof(_GuiStackControlSetVertStacking));
            }

            _GuiStackControlSetVertStackingFunc(ctrl, type);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiStackControlGetPadding(IntPtr ctrl);
         private static _GuiStackControlGetPadding _GuiStackControlGetPaddingFunc;
         internal static int GuiStackControlGetPadding(IntPtr ctrl)
         {
            if (_GuiStackControlGetPaddingFunc == null)
            {
               _GuiStackControlGetPaddingFunc =
                  (_GuiStackControlGetPadding)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlGetPadding"), typeof(_GuiStackControlGetPadding));
            }

            return _GuiStackControlGetPaddingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiStackControlSetPadding(IntPtr ctrl, int padding);
         private static _GuiStackControlSetPadding _GuiStackControlSetPaddingFunc;
         internal static void GuiStackControlSetPadding(IntPtr ctrl, int padding)
         {
            if (_GuiStackControlSetPaddingFunc == null)
            {
               _GuiStackControlSetPaddingFunc =
                  (_GuiStackControlSetPadding)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlSetPadding"), typeof(_GuiStackControlSetPadding));
            }

            _GuiStackControlSetPaddingFunc(ctrl, padding);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiStackControlCreateInstance();
         private static _GuiStackControlCreateInstance _GuiStackControlCreateInstanceFunc;
         internal static IntPtr GuiStackControlCreateInstance()
         {
            if (_GuiStackControlCreateInstanceFunc == null)
            {
               _GuiStackControlCreateInstanceFunc =
                  (_GuiStackControlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlCreateInstance"), typeof(_GuiStackControlCreateInstance));
            }

            return _GuiStackControlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiStackControlUpdateStack(IntPtr ctrl);
         private static _GuiStackControlUpdateStack _GuiStackControlUpdateStackFunc;
         internal static void GuiStackControlUpdateStack(IntPtr ctrl)
         {
            if (_GuiStackControlUpdateStackFunc == null)
            {
               _GuiStackControlUpdateStackFunc =
                  (_GuiStackControlUpdateStack)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiStackControlUpdateStack"), typeof(_GuiStackControlUpdateStack));
            }

            _GuiStackControlUpdateStackFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public int StackingType
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiStackControlGetStackingType(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiStackControlSetStackingType(ObjectPtr->ObjPtr, value);
         }
      }
      public int HorizStacking
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiStackControlGetHorizStacking(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiStackControlSetHorizStacking(ObjectPtr->ObjPtr, value);
         }
      }
      public int VertStacking
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiStackControlGetVertStacking(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiStackControlSetVertStacking(ObjectPtr->ObjPtr, value);
         }
      }
      public int Padding
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiStackControlGetPadding(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiStackControlSetPadding(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void UpdateStack()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiStackControlUpdateStack(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}