using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiColorPickerCtrl : GuiControl
   {
      
      public GuiColorPickerCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiColorPickerCtrlCreateInstance());
      }

      public GuiColorPickerCtrl(uint pId) : base(pId)
      {
      }

      public GuiColorPickerCtrl(string pName) : base(pName)
      {
      }

      public GuiColorPickerCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiColorPickerCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiColorPickerCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlGetBaseColor(IntPtr ctrl, out Color outColor);
         private static _GuiColorPickerCtrlGetBaseColor _GuiColorPickerCtrlGetBaseColorFunc;
         internal static void GuiColorPickerCtrlGetBaseColor(IntPtr ctrl, out Color outColor)
         {
            if (_GuiColorPickerCtrlGetBaseColorFunc == null)
            {
               _GuiColorPickerCtrlGetBaseColorFunc =
                  (_GuiColorPickerCtrlGetBaseColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlGetBaseColor"), typeof(_GuiColorPickerCtrlGetBaseColor));
            }

            _GuiColorPickerCtrlGetBaseColorFunc(ctrl, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlSetBaseColor(IntPtr ctrl, Color color);
         private static _GuiColorPickerCtrlSetBaseColor _GuiColorPickerCtrlSetBaseColorFunc;
         internal static void GuiColorPickerCtrlSetBaseColor(IntPtr ctrl, Color color)
         {
            if (_GuiColorPickerCtrlSetBaseColorFunc == null)
            {
               _GuiColorPickerCtrlSetBaseColorFunc =
                  (_GuiColorPickerCtrlSetBaseColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlSetBaseColor"), typeof(_GuiColorPickerCtrlSetBaseColor));
            }

            _GuiColorPickerCtrlSetBaseColorFunc(ctrl, color);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlGetPickColor(IntPtr ctrl, out Color outColor);
         private static _GuiColorPickerCtrlGetPickColor _GuiColorPickerCtrlGetPickColorFunc;
         internal static void GuiColorPickerCtrlGetPickColor(IntPtr ctrl, out Color outColor)
         {
            if (_GuiColorPickerCtrlGetPickColorFunc == null)
            {
               _GuiColorPickerCtrlGetPickColorFunc =
                  (_GuiColorPickerCtrlGetPickColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlGetPickColor"), typeof(_GuiColorPickerCtrlGetPickColor));
            }

            _GuiColorPickerCtrlGetPickColorFunc(ctrl, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlSetPickColor(IntPtr ctrl, Color color);
         private static _GuiColorPickerCtrlSetPickColor _GuiColorPickerCtrlSetPickColorFunc;
         internal static void GuiColorPickerCtrlSetPickColor(IntPtr ctrl, Color color)
         {
            if (_GuiColorPickerCtrlSetPickColorFunc == null)
            {
               _GuiColorPickerCtrlSetPickColorFunc =
                  (_GuiColorPickerCtrlSetPickColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlSetPickColor"), typeof(_GuiColorPickerCtrlSetPickColor));
            }

            _GuiColorPickerCtrlSetPickColorFunc(ctrl, color);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiColorPickerCtrlGetSelectorGap(IntPtr ctrl);
         private static _GuiColorPickerCtrlGetSelectorGap _GuiColorPickerCtrlGetSelectorGapFunc;
         internal static int GuiColorPickerCtrlGetSelectorGap(IntPtr ctrl)
         {
            if (_GuiColorPickerCtrlGetSelectorGapFunc == null)
            {
               _GuiColorPickerCtrlGetSelectorGapFunc =
                  (_GuiColorPickerCtrlGetSelectorGap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlGetSelectorGap"), typeof(_GuiColorPickerCtrlGetSelectorGap));
            }

            return _GuiColorPickerCtrlGetSelectorGapFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlSetSelectorGap(IntPtr ctrl, int gap);
         private static _GuiColorPickerCtrlSetSelectorGap _GuiColorPickerCtrlSetSelectorGapFunc;
         internal static void GuiColorPickerCtrlSetSelectorGap(IntPtr ctrl, int gap)
         {
            if (_GuiColorPickerCtrlSetSelectorGapFunc == null)
            {
               _GuiColorPickerCtrlSetSelectorGapFunc =
                  (_GuiColorPickerCtrlSetSelectorGap)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlSetSelectorGap"), typeof(_GuiColorPickerCtrlSetSelectorGap));
            }

            _GuiColorPickerCtrlSetSelectorGapFunc(ctrl, gap);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiColorPickerCtrlGetDisplayMode(IntPtr ctrl);
         private static _GuiColorPickerCtrlGetDisplayMode _GuiColorPickerCtrlGetDisplayModeFunc;
         internal static int GuiColorPickerCtrlGetDisplayMode(IntPtr ctrl)
         {
            if (_GuiColorPickerCtrlGetDisplayModeFunc == null)
            {
               _GuiColorPickerCtrlGetDisplayModeFunc =
                  (_GuiColorPickerCtrlGetDisplayMode)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlGetDisplayMode"), typeof(_GuiColorPickerCtrlGetDisplayMode));
            }

            return _GuiColorPickerCtrlGetDisplayModeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlSetDisplayMode(IntPtr ctrl, int mode);
         private static _GuiColorPickerCtrlSetDisplayMode _GuiColorPickerCtrlSetDisplayModeFunc;
         internal static void GuiColorPickerCtrlSetDisplayMode(IntPtr ctrl, int mode)
         {
            if (_GuiColorPickerCtrlSetDisplayModeFunc == null)
            {
               _GuiColorPickerCtrlSetDisplayModeFunc =
                  (_GuiColorPickerCtrlSetDisplayMode)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlSetDisplayMode"), typeof(_GuiColorPickerCtrlSetDisplayMode));
            }

            _GuiColorPickerCtrlSetDisplayModeFunc(ctrl, mode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiColorPickerCtrlGetActionOnMove(IntPtr ctrl);
         private static _GuiColorPickerCtrlGetActionOnMove _GuiColorPickerCtrlGetActionOnMoveFunc;
         internal static bool GuiColorPickerCtrlGetActionOnMove(IntPtr ctrl)
         {
            if (_GuiColorPickerCtrlGetActionOnMoveFunc == null)
            {
               _GuiColorPickerCtrlGetActionOnMoveFunc =
                  (_GuiColorPickerCtrlGetActionOnMove)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlGetActionOnMove"), typeof(_GuiColorPickerCtrlGetActionOnMove));
            }

            return _GuiColorPickerCtrlGetActionOnMoveFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlSetActionOnMove(IntPtr ctrl, bool actionOnMove);
         private static _GuiColorPickerCtrlSetActionOnMove _GuiColorPickerCtrlSetActionOnMoveFunc;
         internal static void GuiColorPickerCtrlSetActionOnMove(IntPtr ctrl, bool actionOnMove)
         {
            if (_GuiColorPickerCtrlSetActionOnMoveFunc == null)
            {
               _GuiColorPickerCtrlSetActionOnMoveFunc =
                  (_GuiColorPickerCtrlSetActionOnMove)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlSetActionOnMove"), typeof(_GuiColorPickerCtrlSetActionOnMove));
            }

            _GuiColorPickerCtrlSetActionOnMoveFunc(ctrl, actionOnMove);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiColorPickerCtrlGetShowSelector(IntPtr ctrl);
         private static _GuiColorPickerCtrlGetShowSelector _GuiColorPickerCtrlGetShowSelectorFunc;
         internal static bool GuiColorPickerCtrlGetShowSelector(IntPtr ctrl)
         {
            if (_GuiColorPickerCtrlGetShowSelectorFunc == null)
            {
               _GuiColorPickerCtrlGetShowSelectorFunc =
                  (_GuiColorPickerCtrlGetShowSelector)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlGetShowSelector"), typeof(_GuiColorPickerCtrlGetShowSelector));
            }

            return _GuiColorPickerCtrlGetShowSelectorFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlSetShowSelector(IntPtr ctrl, bool showSelector);
         private static _GuiColorPickerCtrlSetShowSelector _GuiColorPickerCtrlSetShowSelectorFunc;
         internal static void GuiColorPickerCtrlSetShowSelector(IntPtr ctrl, bool showSelector)
         {
            if (_GuiColorPickerCtrlSetShowSelectorFunc == null)
            {
               _GuiColorPickerCtrlSetShowSelectorFunc =
                  (_GuiColorPickerCtrlSetShowSelector)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlSetShowSelector"), typeof(_GuiColorPickerCtrlSetShowSelector));
            }

            _GuiColorPickerCtrlSetShowSelectorFunc(ctrl, showSelector);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiColorPickerCtrlCreateInstance();
         private static _GuiColorPickerCtrlCreateInstance _GuiColorPickerCtrlCreateInstanceFunc;
         internal static IntPtr GuiColorPickerCtrlCreateInstance()
         {
            if (_GuiColorPickerCtrlCreateInstanceFunc == null)
            {
               _GuiColorPickerCtrlCreateInstanceFunc =
                  (_GuiColorPickerCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlCreateInstance"), typeof(_GuiColorPickerCtrlCreateInstance));
            }

            return _GuiColorPickerCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlGetSelectorPos(IntPtr ctrl, Point2I outPos);
         private static _GuiColorPickerCtrlGetSelectorPos _GuiColorPickerCtrlGetSelectorPosFunc;
         internal static void GuiColorPickerCtrlGetSelectorPos(IntPtr ctrl, Point2I outPos)
         {
            if (_GuiColorPickerCtrlGetSelectorPosFunc == null)
            {
               _GuiColorPickerCtrlGetSelectorPosFunc =
                  (_GuiColorPickerCtrlGetSelectorPos)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlGetSelectorPos"), typeof(_GuiColorPickerCtrlGetSelectorPos));
            }

            _GuiColorPickerCtrlGetSelectorPosFunc(ctrl, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlGetSelectorPosForColor(IntPtr ctrl, Color col, Point2I outPos);
         private static _GuiColorPickerCtrlGetSelectorPosForColor _GuiColorPickerCtrlGetSelectorPosForColorFunc;
         internal static void GuiColorPickerCtrlGetSelectorPosForColor(IntPtr ctrl, Color col, Point2I outPos)
         {
            if (_GuiColorPickerCtrlGetSelectorPosForColorFunc == null)
            {
               _GuiColorPickerCtrlGetSelectorPosForColorFunc =
                  (_GuiColorPickerCtrlGetSelectorPosForColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlGetSelectorPosForColor"), typeof(_GuiColorPickerCtrlGetSelectorPosForColor));
            }

            _GuiColorPickerCtrlGetSelectorPosForColorFunc(ctrl, col, outPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlSetSelectorPos(IntPtr ctrl, Point2I pos);
         private static _GuiColorPickerCtrlSetSelectorPos _GuiColorPickerCtrlSetSelectorPosFunc;
         internal static void GuiColorPickerCtrlSetSelectorPos(IntPtr ctrl, Point2I pos)
         {
            if (_GuiColorPickerCtrlSetSelectorPosFunc == null)
            {
               _GuiColorPickerCtrlSetSelectorPosFunc =
                  (_GuiColorPickerCtrlSetSelectorPos)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlSetSelectorPos"), typeof(_GuiColorPickerCtrlSetSelectorPos));
            }

            _GuiColorPickerCtrlSetSelectorPosFunc(ctrl, pos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiColorPickerCtrlUpdateColor(IntPtr ctrl);
         private static _GuiColorPickerCtrlUpdateColor _GuiColorPickerCtrlUpdateColorFunc;
         internal static void GuiColorPickerCtrlUpdateColor(IntPtr ctrl)
         {
            if (_GuiColorPickerCtrlUpdateColorFunc == null)
            {
               _GuiColorPickerCtrlUpdateColorFunc =
                  (_GuiColorPickerCtrlUpdateColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiColorPickerCtrlUpdateColor"), typeof(_GuiColorPickerCtrlUpdateColor));
            }

            _GuiColorPickerCtrlUpdateColorFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public Color BaseColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiColorPickerCtrlGetBaseColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiColorPickerCtrlSetBaseColor(ObjectPtr->ObjPtr, value);
         }
      }
      public Color PickColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiColorPickerCtrlGetPickColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiColorPickerCtrlSetPickColor(ObjectPtr->ObjPtr, value);
         }
      }
      public int SelectorGap
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiColorPickerCtrlGetSelectorGap(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiColorPickerCtrlSetSelectorGap(ObjectPtr->ObjPtr, value);
         }
      }
      public int DisplayMode
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiColorPickerCtrlGetDisplayMode(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiColorPickerCtrlSetDisplayMode(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ActionOnMove
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiColorPickerCtrlGetActionOnMove(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiColorPickerCtrlSetActionOnMove(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ShowSelector
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiColorPickerCtrlGetShowSelector(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiColorPickerCtrlSetShowSelector(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void GetSelectorPos(Point2I outPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiColorPickerCtrlGetSelectorPos(ObjectPtr->ObjPtr, outPos);
      }

      public void GetSelectorPosForColor(Color col, Point2I outPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiColorPickerCtrlGetSelectorPosForColor(ObjectPtr->ObjPtr, col, outPos);
      }

      public void SetSelectorPos(Point2I pos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiColorPickerCtrlSetSelectorPos(ObjectPtr->ObjPtr, pos);
      }

      public void UpdateColor()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiColorPickerCtrlUpdateColor(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}