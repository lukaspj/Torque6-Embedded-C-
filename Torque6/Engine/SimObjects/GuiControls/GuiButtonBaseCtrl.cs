using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiButtonBaseCtrl : GuiControl
   {
      
      public GuiButtonBaseCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiButtonBaseCtrlCreateInstance());
      }

      public GuiButtonBaseCtrl(uint pId) : base(pId)
      {
      }

      public GuiButtonBaseCtrl(string pName) : base(pName)
      {
      }

      public GuiButtonBaseCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiButtonBaseCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiButtonBaseCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiButtonBaseCtrlGetText(IntPtr ctrl);
         private static _GuiButtonBaseCtrlGetText _GuiButtonBaseCtrlGetTextFunc;
         internal static IntPtr GuiButtonBaseCtrlGetText(IntPtr ctrl)
         {
            if (_GuiButtonBaseCtrlGetTextFunc == null)
            {
               _GuiButtonBaseCtrlGetTextFunc =
                  (_GuiButtonBaseCtrlGetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlGetText"), typeof(_GuiButtonBaseCtrlGetText));
            }

            return _GuiButtonBaseCtrlGetTextFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiButtonBaseCtrlSetText(IntPtr ctrl, string text);
         private static _GuiButtonBaseCtrlSetText _GuiButtonBaseCtrlSetTextFunc;
         internal static void GuiButtonBaseCtrlSetText(IntPtr ctrl, string text)
         {
            if (_GuiButtonBaseCtrlSetTextFunc == null)
            {
               _GuiButtonBaseCtrlSetTextFunc =
                  (_GuiButtonBaseCtrlSetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlSetText"), typeof(_GuiButtonBaseCtrlSetText));
            }

            _GuiButtonBaseCtrlSetTextFunc(ctrl, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiButtonBaseCtrlGetTextID(IntPtr ctrl);
         private static _GuiButtonBaseCtrlGetTextID _GuiButtonBaseCtrlGetTextIDFunc;
         internal static IntPtr GuiButtonBaseCtrlGetTextID(IntPtr ctrl)
         {
            if (_GuiButtonBaseCtrlGetTextIDFunc == null)
            {
               _GuiButtonBaseCtrlGetTextIDFunc =
                  (_GuiButtonBaseCtrlGetTextID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlGetTextID"), typeof(_GuiButtonBaseCtrlGetTextID));
            }

            return _GuiButtonBaseCtrlGetTextIDFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiButtonBaseCtrlSetTextID(IntPtr ctrl, string textId);
         private static _GuiButtonBaseCtrlSetTextID _GuiButtonBaseCtrlSetTextIDFunc;
         internal static void GuiButtonBaseCtrlSetTextID(IntPtr ctrl, string textId)
         {
            if (_GuiButtonBaseCtrlSetTextIDFunc == null)
            {
               _GuiButtonBaseCtrlSetTextIDFunc =
                  (_GuiButtonBaseCtrlSetTextID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlSetTextID"), typeof(_GuiButtonBaseCtrlSetTextID));
            }

            _GuiButtonBaseCtrlSetTextIDFunc(ctrl, textId);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiButtonBaseCtrlGetGroupNum(IntPtr ctrl);
         private static _GuiButtonBaseCtrlGetGroupNum _GuiButtonBaseCtrlGetGroupNumFunc;
         internal static int GuiButtonBaseCtrlGetGroupNum(IntPtr ctrl)
         {
            if (_GuiButtonBaseCtrlGetGroupNumFunc == null)
            {
               _GuiButtonBaseCtrlGetGroupNumFunc =
                  (_GuiButtonBaseCtrlGetGroupNum)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlGetGroupNum"), typeof(_GuiButtonBaseCtrlGetGroupNum));
            }

            return _GuiButtonBaseCtrlGetGroupNumFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiButtonBaseCtrlSetGroupNum(IntPtr ctrl, int groupNum);
         private static _GuiButtonBaseCtrlSetGroupNum _GuiButtonBaseCtrlSetGroupNumFunc;
         internal static void GuiButtonBaseCtrlSetGroupNum(IntPtr ctrl, int groupNum)
         {
            if (_GuiButtonBaseCtrlSetGroupNumFunc == null)
            {
               _GuiButtonBaseCtrlSetGroupNumFunc =
                  (_GuiButtonBaseCtrlSetGroupNum)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlSetGroupNum"), typeof(_GuiButtonBaseCtrlSetGroupNum));
            }

            _GuiButtonBaseCtrlSetGroupNumFunc(ctrl, groupNum);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiButtonBaseCtrlGetButtonType(IntPtr ctrl);
         private static _GuiButtonBaseCtrlGetButtonType _GuiButtonBaseCtrlGetButtonTypeFunc;
         internal static int GuiButtonBaseCtrlGetButtonType(IntPtr ctrl)
         {
            if (_GuiButtonBaseCtrlGetButtonTypeFunc == null)
            {
               _GuiButtonBaseCtrlGetButtonTypeFunc =
                  (_GuiButtonBaseCtrlGetButtonType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlGetButtonType"), typeof(_GuiButtonBaseCtrlGetButtonType));
            }

            return _GuiButtonBaseCtrlGetButtonTypeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiButtonBaseCtrlSetButtonType(IntPtr ctrl, int buttonType);
         private static _GuiButtonBaseCtrlSetButtonType _GuiButtonBaseCtrlSetButtonTypeFunc;
         internal static void GuiButtonBaseCtrlSetButtonType(IntPtr ctrl, int buttonType)
         {
            if (_GuiButtonBaseCtrlSetButtonTypeFunc == null)
            {
               _GuiButtonBaseCtrlSetButtonTypeFunc =
                  (_GuiButtonBaseCtrlSetButtonType)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlSetButtonType"), typeof(_GuiButtonBaseCtrlSetButtonType));
            }

            _GuiButtonBaseCtrlSetButtonTypeFunc(ctrl, buttonType);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiButtonBaseCtrlGetUseMouseEvents(IntPtr ctrl);
         private static _GuiButtonBaseCtrlGetUseMouseEvents _GuiButtonBaseCtrlGetUseMouseEventsFunc;
         internal static bool GuiButtonBaseCtrlGetUseMouseEvents(IntPtr ctrl)
         {
            if (_GuiButtonBaseCtrlGetUseMouseEventsFunc == null)
            {
               _GuiButtonBaseCtrlGetUseMouseEventsFunc =
                  (_GuiButtonBaseCtrlGetUseMouseEvents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlGetUseMouseEvents"), typeof(_GuiButtonBaseCtrlGetUseMouseEvents));
            }

            return _GuiButtonBaseCtrlGetUseMouseEventsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiButtonBaseCtrlSetUseMouseEvents(IntPtr ctrl, bool useMouseEvents);
         private static _GuiButtonBaseCtrlSetUseMouseEvents _GuiButtonBaseCtrlSetUseMouseEventsFunc;
         internal static void GuiButtonBaseCtrlSetUseMouseEvents(IntPtr ctrl, bool useMouseEvents)
         {
            if (_GuiButtonBaseCtrlSetUseMouseEventsFunc == null)
            {
               _GuiButtonBaseCtrlSetUseMouseEventsFunc =
                  (_GuiButtonBaseCtrlSetUseMouseEvents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlSetUseMouseEvents"), typeof(_GuiButtonBaseCtrlSetUseMouseEvents));
            }

            _GuiButtonBaseCtrlSetUseMouseEventsFunc(ctrl, useMouseEvents);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiButtonBaseCtrlCreateInstance();
         private static _GuiButtonBaseCtrlCreateInstance _GuiButtonBaseCtrlCreateInstanceFunc;
         internal static IntPtr GuiButtonBaseCtrlCreateInstance()
         {
            if (_GuiButtonBaseCtrlCreateInstanceFunc == null)
            {
               _GuiButtonBaseCtrlCreateInstanceFunc =
                  (_GuiButtonBaseCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlCreateInstance"), typeof(_GuiButtonBaseCtrlCreateInstance));
            }

            return _GuiButtonBaseCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiButtonBaseCtrlPerformClick(IntPtr ctrl);
         private static _GuiButtonBaseCtrlPerformClick _GuiButtonBaseCtrlPerformClickFunc;
         internal static void GuiButtonBaseCtrlPerformClick(IntPtr ctrl)
         {
            if (_GuiButtonBaseCtrlPerformClickFunc == null)
            {
               _GuiButtonBaseCtrlPerformClickFunc =
                  (_GuiButtonBaseCtrlPerformClick)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlPerformClick"), typeof(_GuiButtonBaseCtrlPerformClick));
            }

            _GuiButtonBaseCtrlPerformClickFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiButtonBaseCtrlSetStateOn(IntPtr ctrl, bool isStateOn);
         private static _GuiButtonBaseCtrlSetStateOn _GuiButtonBaseCtrlSetStateOnFunc;
         internal static void GuiButtonBaseCtrlSetStateOn(IntPtr ctrl, bool isStateOn)
         {
            if (_GuiButtonBaseCtrlSetStateOnFunc == null)
            {
               _GuiButtonBaseCtrlSetStateOnFunc =
                  (_GuiButtonBaseCtrlSetStateOn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlSetStateOn"), typeof(_GuiButtonBaseCtrlSetStateOn));
            }

            _GuiButtonBaseCtrlSetStateOnFunc(ctrl, isStateOn);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiButtonBaseCtrlGetStateOn(IntPtr ctrl);
         private static _GuiButtonBaseCtrlGetStateOn _GuiButtonBaseCtrlGetStateOnFunc;
         internal static bool GuiButtonBaseCtrlGetStateOn(IntPtr ctrl)
         {
            if (_GuiButtonBaseCtrlGetStateOnFunc == null)
            {
               _GuiButtonBaseCtrlGetStateOnFunc =
                  (_GuiButtonBaseCtrlGetStateOn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiButtonBaseCtrlGetStateOn"), typeof(_GuiButtonBaseCtrlGetStateOn));
            }

            return _GuiButtonBaseCtrlGetStateOnFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public string Text
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiButtonBaseCtrlGetText(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiButtonBaseCtrlSetText(ObjectPtr->ObjPtr, value);
         }
      }
      public string TextID
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiButtonBaseCtrlGetTextID(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiButtonBaseCtrlSetTextID(ObjectPtr->ObjPtr, value);
         }
      }
      public int GroupNum
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiButtonBaseCtrlGetGroupNum(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiButtonBaseCtrlSetGroupNum(ObjectPtr->ObjPtr, value);
         }
      }
      public int ButtonType
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiButtonBaseCtrlGetButtonType(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiButtonBaseCtrlSetButtonType(ObjectPtr->ObjPtr, value);
         }
      }
      public bool UseMouseEvents
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiButtonBaseCtrlGetUseMouseEvents(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiButtonBaseCtrlSetUseMouseEvents(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void PerformClick()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiButtonBaseCtrlPerformClick(ObjectPtr->ObjPtr);
      }

      public void SetStateOn(bool isStateOn)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiButtonBaseCtrlSetStateOn(ObjectPtr->ObjPtr, isStateOn);
      }

      public bool GetStateOn()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiButtonBaseCtrlGetStateOn(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}