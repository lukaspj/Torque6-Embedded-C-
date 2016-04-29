using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiFrameSetCtrl : GuiControl
   {
      
      public GuiFrameSetCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiFrameSetCtrlCreateInstance());
      }

      public GuiFrameSetCtrl(uint pId) : base(pId)
      {
      }

      public GuiFrameSetCtrl(string pName) : base(pName)
      {
      }

      public GuiFrameSetCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiFrameSetCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiFrameSetCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFrameSetCtrlGetBorderWidth(IntPtr ctrl);
         private static _GuiFrameSetCtrlGetBorderWidth _GuiFrameSetCtrlGetBorderWidthFunc;
         internal static int GuiFrameSetCtrlGetBorderWidth(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlGetBorderWidthFunc == null)
            {
               _GuiFrameSetCtrlGetBorderWidthFunc =
                  (_GuiFrameSetCtrlGetBorderWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetBorderWidth"), typeof(_GuiFrameSetCtrlGetBorderWidth));
            }

            return _GuiFrameSetCtrlGetBorderWidthFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlSetBorderWidth(IntPtr ctrl, int width);
         private static _GuiFrameSetCtrlSetBorderWidth _GuiFrameSetCtrlSetBorderWidthFunc;
         internal static void GuiFrameSetCtrlSetBorderWidth(IntPtr ctrl, int width)
         {
            if (_GuiFrameSetCtrlSetBorderWidthFunc == null)
            {
               _GuiFrameSetCtrlSetBorderWidthFunc =
                  (_GuiFrameSetCtrlSetBorderWidth)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlSetBorderWidth"), typeof(_GuiFrameSetCtrlSetBorderWidth));
            }

            _GuiFrameSetCtrlSetBorderWidthFunc(ctrl, width);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlGetBorderColor(IntPtr ctrl, out Color outCol);
         private static _GuiFrameSetCtrlGetBorderColor _GuiFrameSetCtrlGetBorderColorFunc;
         internal static void GuiFrameSetCtrlGetBorderColor(IntPtr ctrl, out Color outCol)
         {
            if (_GuiFrameSetCtrlGetBorderColorFunc == null)
            {
               _GuiFrameSetCtrlGetBorderColorFunc =
                  (_GuiFrameSetCtrlGetBorderColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetBorderColor"), typeof(_GuiFrameSetCtrlGetBorderColor));
            }

            _GuiFrameSetCtrlGetBorderColorFunc(ctrl, out outCol);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlSetBorderColor(IntPtr ctrl, Color color);
         private static _GuiFrameSetCtrlSetBorderColor _GuiFrameSetCtrlSetBorderColorFunc;
         internal static void GuiFrameSetCtrlSetBorderColor(IntPtr ctrl, Color color)
         {
            if (_GuiFrameSetCtrlSetBorderColorFunc == null)
            {
               _GuiFrameSetCtrlSetBorderColorFunc =
                  (_GuiFrameSetCtrlSetBorderColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlSetBorderColor"), typeof(_GuiFrameSetCtrlSetBorderColor));
            }

            _GuiFrameSetCtrlSetBorderColorFunc(ctrl, color);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFrameSetCtrlGetBorderEnable(IntPtr ctrl);
         private static _GuiFrameSetCtrlGetBorderEnable _GuiFrameSetCtrlGetBorderEnableFunc;
         internal static int GuiFrameSetCtrlGetBorderEnable(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlGetBorderEnableFunc == null)
            {
               _GuiFrameSetCtrlGetBorderEnableFunc =
                  (_GuiFrameSetCtrlGetBorderEnable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetBorderEnable"), typeof(_GuiFrameSetCtrlGetBorderEnable));
            }

            return _GuiFrameSetCtrlGetBorderEnableFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlSetBorderEnable(IntPtr ctrl, int enable);
         private static _GuiFrameSetCtrlSetBorderEnable _GuiFrameSetCtrlSetBorderEnableFunc;
         internal static void GuiFrameSetCtrlSetBorderEnable(IntPtr ctrl, int enable)
         {
            if (_GuiFrameSetCtrlSetBorderEnableFunc == null)
            {
               _GuiFrameSetCtrlSetBorderEnableFunc =
                  (_GuiFrameSetCtrlSetBorderEnable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlSetBorderEnable"), typeof(_GuiFrameSetCtrlSetBorderEnable));
            }

            _GuiFrameSetCtrlSetBorderEnableFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFrameSetCtrlGetBorderMovable(IntPtr ctrl);
         private static _GuiFrameSetCtrlGetBorderMovable _GuiFrameSetCtrlGetBorderMovableFunc;
         internal static int GuiFrameSetCtrlGetBorderMovable(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlGetBorderMovableFunc == null)
            {
               _GuiFrameSetCtrlGetBorderMovableFunc =
                  (_GuiFrameSetCtrlGetBorderMovable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetBorderMovable"), typeof(_GuiFrameSetCtrlGetBorderMovable));
            }

            return _GuiFrameSetCtrlGetBorderMovableFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlSetBorderMovable(IntPtr ctrl, int movable);
         private static _GuiFrameSetCtrlSetBorderMovable _GuiFrameSetCtrlSetBorderMovableFunc;
         internal static void GuiFrameSetCtrlSetBorderMovable(IntPtr ctrl, int movable)
         {
            if (_GuiFrameSetCtrlSetBorderMovableFunc == null)
            {
               _GuiFrameSetCtrlSetBorderMovableFunc =
                  (_GuiFrameSetCtrlSetBorderMovable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlSetBorderMovable"), typeof(_GuiFrameSetCtrlSetBorderMovable));
            }

            _GuiFrameSetCtrlSetBorderMovableFunc(ctrl, movable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiFrameSetCtrlGetAutoBalance(IntPtr ctrl);
         private static _GuiFrameSetCtrlGetAutoBalance _GuiFrameSetCtrlGetAutoBalanceFunc;
         internal static bool GuiFrameSetCtrlGetAutoBalance(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlGetAutoBalanceFunc == null)
            {
               _GuiFrameSetCtrlGetAutoBalanceFunc =
                  (_GuiFrameSetCtrlGetAutoBalance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetAutoBalance"), typeof(_GuiFrameSetCtrlGetAutoBalance));
            }

            return _GuiFrameSetCtrlGetAutoBalanceFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlSetAutoBalance(IntPtr ctrl, bool enable);
         private static _GuiFrameSetCtrlSetAutoBalance _GuiFrameSetCtrlSetAutoBalanceFunc;
         internal static void GuiFrameSetCtrlSetAutoBalance(IntPtr ctrl, bool enable)
         {
            if (_GuiFrameSetCtrlSetAutoBalanceFunc == null)
            {
               _GuiFrameSetCtrlSetAutoBalanceFunc =
                  (_GuiFrameSetCtrlSetAutoBalance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlSetAutoBalance"), typeof(_GuiFrameSetCtrlSetAutoBalance));
            }

            _GuiFrameSetCtrlSetAutoBalanceFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFrameSetCtrlGetFudgeFactor(IntPtr ctrl);
         private static _GuiFrameSetCtrlGetFudgeFactor _GuiFrameSetCtrlGetFudgeFactorFunc;
         internal static int GuiFrameSetCtrlGetFudgeFactor(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlGetFudgeFactorFunc == null)
            {
               _GuiFrameSetCtrlGetFudgeFactorFunc =
                  (_GuiFrameSetCtrlGetFudgeFactor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetFudgeFactor"), typeof(_GuiFrameSetCtrlGetFudgeFactor));
            }

            return _GuiFrameSetCtrlGetFudgeFactorFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlSetFudgeFactor(IntPtr ctrl, int fudgeFactor);
         private static _GuiFrameSetCtrlSetFudgeFactor _GuiFrameSetCtrlSetFudgeFactorFunc;
         internal static void GuiFrameSetCtrlSetFudgeFactor(IntPtr ctrl, int fudgeFactor)
         {
            if (_GuiFrameSetCtrlSetFudgeFactorFunc == null)
            {
               _GuiFrameSetCtrlSetFudgeFactorFunc =
                  (_GuiFrameSetCtrlSetFudgeFactor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlSetFudgeFactor"), typeof(_GuiFrameSetCtrlSetFudgeFactor));
            }

            _GuiFrameSetCtrlSetFudgeFactorFunc(ctrl, fudgeFactor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFrameSetCtrlCreateInstance();
         private static _GuiFrameSetCtrlCreateInstance _GuiFrameSetCtrlCreateInstanceFunc;
         internal static IntPtr GuiFrameSetCtrlCreateInstance()
         {
            if (_GuiFrameSetCtrlCreateInstanceFunc == null)
            {
               _GuiFrameSetCtrlCreateInstanceFunc =
                  (_GuiFrameSetCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlCreateInstance"), typeof(_GuiFrameSetCtrlCreateInstance));
            }

            return _GuiFrameSetCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlFrameBorder(IntPtr ctrl, int index, string state);
         private static _GuiFrameSetCtrlFrameBorder _GuiFrameSetCtrlFrameBorderFunc;
         internal static void GuiFrameSetCtrlFrameBorder(IntPtr ctrl, int index, string state)
         {
            if (_GuiFrameSetCtrlFrameBorderFunc == null)
            {
               _GuiFrameSetCtrlFrameBorderFunc =
                  (_GuiFrameSetCtrlFrameBorder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlFrameBorder"), typeof(_GuiFrameSetCtrlFrameBorder));
            }

            _GuiFrameSetCtrlFrameBorderFunc(ctrl, index, state);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlFrameMovable(IntPtr ctrl, int index, string state);
         private static _GuiFrameSetCtrlFrameMovable _GuiFrameSetCtrlFrameMovableFunc;
         internal static void GuiFrameSetCtrlFrameMovable(IntPtr ctrl, int index, string state)
         {
            if (_GuiFrameSetCtrlFrameMovableFunc == null)
            {
               _GuiFrameSetCtrlFrameMovableFunc =
                  (_GuiFrameSetCtrlFrameMovable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlFrameMovable"), typeof(_GuiFrameSetCtrlFrameMovable));
            }

            _GuiFrameSetCtrlFrameMovableFunc(ctrl, index, state);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlFrameMinExtent(IntPtr ctrl, int index, int width, int height);
         private static _GuiFrameSetCtrlFrameMinExtent _GuiFrameSetCtrlFrameMinExtentFunc;
         internal static void GuiFrameSetCtrlFrameMinExtent(IntPtr ctrl, int index, int width, int height)
         {
            if (_GuiFrameSetCtrlFrameMinExtentFunc == null)
            {
               _GuiFrameSetCtrlFrameMinExtentFunc =
                  (_GuiFrameSetCtrlFrameMinExtent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlFrameMinExtent"), typeof(_GuiFrameSetCtrlFrameMinExtent));
            }

            _GuiFrameSetCtrlFrameMinExtentFunc(ctrl, index, width, height);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlAddColumn(IntPtr ctrl);
         private static _GuiFrameSetCtrlAddColumn _GuiFrameSetCtrlAddColumnFunc;
         internal static void GuiFrameSetCtrlAddColumn(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlAddColumnFunc == null)
            {
               _GuiFrameSetCtrlAddColumnFunc =
                  (_GuiFrameSetCtrlAddColumn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlAddColumn"), typeof(_GuiFrameSetCtrlAddColumn));
            }

            _GuiFrameSetCtrlAddColumnFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlAddRow(IntPtr ctrl);
         private static _GuiFrameSetCtrlAddRow _GuiFrameSetCtrlAddRowFunc;
         internal static void GuiFrameSetCtrlAddRow(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlAddRowFunc == null)
            {
               _GuiFrameSetCtrlAddRowFunc =
                  (_GuiFrameSetCtrlAddRow)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlAddRow"), typeof(_GuiFrameSetCtrlAddRow));
            }

            _GuiFrameSetCtrlAddRowFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlRemoveColumn(IntPtr ctrl);
         private static _GuiFrameSetCtrlRemoveColumn _GuiFrameSetCtrlRemoveColumnFunc;
         internal static void GuiFrameSetCtrlRemoveColumn(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlRemoveColumnFunc == null)
            {
               _GuiFrameSetCtrlRemoveColumnFunc =
                  (_GuiFrameSetCtrlRemoveColumn)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlRemoveColumn"), typeof(_GuiFrameSetCtrlRemoveColumn));
            }

            _GuiFrameSetCtrlRemoveColumnFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlRemoveRow(IntPtr ctrl);
         private static _GuiFrameSetCtrlRemoveRow _GuiFrameSetCtrlRemoveRowFunc;
         internal static void GuiFrameSetCtrlRemoveRow(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlRemoveRowFunc == null)
            {
               _GuiFrameSetCtrlRemoveRowFunc =
                  (_GuiFrameSetCtrlRemoveRow)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlRemoveRow"), typeof(_GuiFrameSetCtrlRemoveRow));
            }

            _GuiFrameSetCtrlRemoveRowFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFrameSetCtrlGetColumnCount(IntPtr ctrl);
         private static _GuiFrameSetCtrlGetColumnCount _GuiFrameSetCtrlGetColumnCountFunc;
         internal static int GuiFrameSetCtrlGetColumnCount(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlGetColumnCountFunc == null)
            {
               _GuiFrameSetCtrlGetColumnCountFunc =
                  (_GuiFrameSetCtrlGetColumnCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetColumnCount"), typeof(_GuiFrameSetCtrlGetColumnCount));
            }

            return _GuiFrameSetCtrlGetColumnCountFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFrameSetCtrlGetRowCount(IntPtr ctrl);
         private static _GuiFrameSetCtrlGetRowCount _GuiFrameSetCtrlGetRowCountFunc;
         internal static int GuiFrameSetCtrlGetRowCount(IntPtr ctrl)
         {
            if (_GuiFrameSetCtrlGetRowCountFunc == null)
            {
               _GuiFrameSetCtrlGetRowCountFunc =
                  (_GuiFrameSetCtrlGetRowCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetRowCount"), typeof(_GuiFrameSetCtrlGetRowCount));
            }

            return _GuiFrameSetCtrlGetRowCountFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFrameSetCtrlGetColumnOffset(IntPtr ctrl, int column);
         private static _GuiFrameSetCtrlGetColumnOffset _GuiFrameSetCtrlGetColumnOffsetFunc;
         internal static int GuiFrameSetCtrlGetColumnOffset(IntPtr ctrl, int column)
         {
            if (_GuiFrameSetCtrlGetColumnOffsetFunc == null)
            {
               _GuiFrameSetCtrlGetColumnOffsetFunc =
                  (_GuiFrameSetCtrlGetColumnOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetColumnOffset"), typeof(_GuiFrameSetCtrlGetColumnOffset));
            }

            return _GuiFrameSetCtrlGetColumnOffsetFunc(ctrl, column);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFrameSetCtrlGetRowOffset(IntPtr ctrl, int row);
         private static _GuiFrameSetCtrlGetRowOffset _GuiFrameSetCtrlGetRowOffsetFunc;
         internal static int GuiFrameSetCtrlGetRowOffset(IntPtr ctrl, int row)
         {
            if (_GuiFrameSetCtrlGetRowOffsetFunc == null)
            {
               _GuiFrameSetCtrlGetRowOffsetFunc =
                  (_GuiFrameSetCtrlGetRowOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlGetRowOffset"), typeof(_GuiFrameSetCtrlGetRowOffset));
            }

            return _GuiFrameSetCtrlGetRowOffsetFunc(ctrl, row);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlSetColumnOffset(IntPtr ctrl, int column, int offset);
         private static _GuiFrameSetCtrlSetColumnOffset _GuiFrameSetCtrlSetColumnOffsetFunc;
         internal static void GuiFrameSetCtrlSetColumnOffset(IntPtr ctrl, int column, int offset)
         {
            if (_GuiFrameSetCtrlSetColumnOffsetFunc == null)
            {
               _GuiFrameSetCtrlSetColumnOffsetFunc =
                  (_GuiFrameSetCtrlSetColumnOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlSetColumnOffset"), typeof(_GuiFrameSetCtrlSetColumnOffset));
            }

            _GuiFrameSetCtrlSetColumnOffsetFunc(ctrl, column, offset);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFrameSetCtrlSetRowOffset(IntPtr ctrl, int row, int offset);
         private static _GuiFrameSetCtrlSetRowOffset _GuiFrameSetCtrlSetRowOffsetFunc;
         internal static void GuiFrameSetCtrlSetRowOffset(IntPtr ctrl, int row, int offset)
         {
            if (_GuiFrameSetCtrlSetRowOffsetFunc == null)
            {
               _GuiFrameSetCtrlSetRowOffsetFunc =
                  (_GuiFrameSetCtrlSetRowOffset)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFrameSetCtrlSetRowOffset"), typeof(_GuiFrameSetCtrlSetRowOffset));
            }

            _GuiFrameSetCtrlSetRowOffsetFunc(ctrl, row, offset);
         }
      }
      
      #endregion

      #region Properties

      public int BorderWidth
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiFrameSetCtrlGetBorderWidth(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFrameSetCtrlSetBorderWidth(ObjectPtr->ObjPtr, value);
         }
      }
      public Color BorderColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiFrameSetCtrlGetBorderColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFrameSetCtrlSetBorderColor(ObjectPtr->ObjPtr, value);
         }
      }
      public int BorderEnable
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiFrameSetCtrlGetBorderEnable(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFrameSetCtrlSetBorderEnable(ObjectPtr->ObjPtr, value);
         }
      }
      public int BorderMovable
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiFrameSetCtrlGetBorderMovable(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFrameSetCtrlSetBorderMovable(ObjectPtr->ObjPtr, value);
         }
      }
      public bool AutoBalance
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiFrameSetCtrlGetAutoBalance(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFrameSetCtrlSetAutoBalance(ObjectPtr->ObjPtr, value);
         }
      }
      public int FudgeFactor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiFrameSetCtrlGetFudgeFactor(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFrameSetCtrlSetFudgeFactor(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void FrameBorder(int index, string state)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFrameSetCtrlFrameBorder(ObjectPtr->ObjPtr, index, state);
      }

      public void FrameMovable(int index, string state)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFrameSetCtrlFrameMovable(ObjectPtr->ObjPtr, index, state);
      }

      public void FrameMinExtent(int index, int width, int height)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFrameSetCtrlFrameMinExtent(ObjectPtr->ObjPtr, index, width, height);
      }

      public void AddColumn()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFrameSetCtrlAddColumn(ObjectPtr->ObjPtr);
      }

      public void AddRow()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFrameSetCtrlAddRow(ObjectPtr->ObjPtr);
      }

      public void RemoveColumn()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFrameSetCtrlRemoveColumn(ObjectPtr->ObjPtr);
      }

      public void RemoveRow()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFrameSetCtrlRemoveRow(ObjectPtr->ObjPtr);
      }

      public int GetColumnCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiFrameSetCtrlGetColumnCount(ObjectPtr->ObjPtr);
      }

      public int GetRowCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiFrameSetCtrlGetRowCount(ObjectPtr->ObjPtr);
      }

      public int GetColumnOffset(int column)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiFrameSetCtrlGetColumnOffset(ObjectPtr->ObjPtr, column);
      }

      public int GetRowOffset(int row)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiFrameSetCtrlGetRowOffset(ObjectPtr->ObjPtr, row);
      }

      public void SetColumnOffset(int column, int offset)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFrameSetCtrlSetColumnOffset(ObjectPtr->ObjPtr, column, offset);
      }

      public void SetRowOffset(int row, int offset)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiFrameSetCtrlSetRowOffset(ObjectPtr->ObjPtr, row, offset);
      }
      
      #endregion

      
   }
}