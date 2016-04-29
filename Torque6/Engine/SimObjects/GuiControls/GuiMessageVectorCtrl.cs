using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiMessageVectorCtrl : GuiControl
   {
      
      public GuiMessageVectorCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiMessageVectorCtrlCreateInstance());
      }

      public GuiMessageVectorCtrl(uint pId) : base(pId)
      {
      }

      public GuiMessageVectorCtrl(string pName) : base(pName)
      {
      }

      public GuiMessageVectorCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMessageVectorCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMessageVectorCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiMessageVectorCtrlGetLineSpacing(IntPtr ctrl);
         private static _GuiMessageVectorCtrlGetLineSpacing _GuiMessageVectorCtrlGetLineSpacingFunc;
         internal static int GuiMessageVectorCtrlGetLineSpacing(IntPtr ctrl)
         {
            if (_GuiMessageVectorCtrlGetLineSpacingFunc == null)
            {
               _GuiMessageVectorCtrlGetLineSpacingFunc =
                  (_GuiMessageVectorCtrlGetLineSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlGetLineSpacing"), typeof(_GuiMessageVectorCtrlGetLineSpacing));
            }

            return _GuiMessageVectorCtrlGetLineSpacingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMessageVectorCtrlSetLineSpacing(IntPtr ctrl, int spacing);
         private static _GuiMessageVectorCtrlSetLineSpacing _GuiMessageVectorCtrlSetLineSpacingFunc;
         internal static void GuiMessageVectorCtrlSetLineSpacing(IntPtr ctrl, int spacing)
         {
            if (_GuiMessageVectorCtrlSetLineSpacingFunc == null)
            {
               _GuiMessageVectorCtrlSetLineSpacingFunc =
                  (_GuiMessageVectorCtrlSetLineSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlSetLineSpacing"), typeof(_GuiMessageVectorCtrlSetLineSpacing));
            }

            _GuiMessageVectorCtrlSetLineSpacingFunc(ctrl, spacing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiMessageVectorCtrlGetLineContinuedIndex(IntPtr ctrl);
         private static _GuiMessageVectorCtrlGetLineContinuedIndex _GuiMessageVectorCtrlGetLineContinuedIndexFunc;
         internal static int GuiMessageVectorCtrlGetLineContinuedIndex(IntPtr ctrl)
         {
            if (_GuiMessageVectorCtrlGetLineContinuedIndexFunc == null)
            {
               _GuiMessageVectorCtrlGetLineContinuedIndexFunc =
                  (_GuiMessageVectorCtrlGetLineContinuedIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlGetLineContinuedIndex"), typeof(_GuiMessageVectorCtrlGetLineContinuedIndex));
            }

            return _GuiMessageVectorCtrlGetLineContinuedIndexFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMessageVectorCtrlSetLineContinuedIndex(IntPtr ctrl, int index);
         private static _GuiMessageVectorCtrlSetLineContinuedIndex _GuiMessageVectorCtrlSetLineContinuedIndexFunc;
         internal static void GuiMessageVectorCtrlSetLineContinuedIndex(IntPtr ctrl, int index)
         {
            if (_GuiMessageVectorCtrlSetLineContinuedIndexFunc == null)
            {
               _GuiMessageVectorCtrlSetLineContinuedIndexFunc =
                  (_GuiMessageVectorCtrlSetLineContinuedIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlSetLineContinuedIndex"), typeof(_GuiMessageVectorCtrlSetLineContinuedIndex));
            }

            _GuiMessageVectorCtrlSetLineContinuedIndexFunc(ctrl, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMessageVectorCtrlGetAllowedMatches(IntPtr ctrl, int index);
         private static _GuiMessageVectorCtrlGetAllowedMatches _GuiMessageVectorCtrlGetAllowedMatchesFunc;
         internal static IntPtr GuiMessageVectorCtrlGetAllowedMatches(IntPtr ctrl, int index)
         {
            if (_GuiMessageVectorCtrlGetAllowedMatchesFunc == null)
            {
               _GuiMessageVectorCtrlGetAllowedMatchesFunc =
                  (_GuiMessageVectorCtrlGetAllowedMatches)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlGetAllowedMatches"), typeof(_GuiMessageVectorCtrlGetAllowedMatches));
            }

            return _GuiMessageVectorCtrlGetAllowedMatchesFunc(ctrl, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMessageVectorCtrlSetAllowedMatches(IntPtr ctrl, int index, string match);
         private static _GuiMessageVectorCtrlSetAllowedMatches _GuiMessageVectorCtrlSetAllowedMatchesFunc;
         internal static void GuiMessageVectorCtrlSetAllowedMatches(IntPtr ctrl, int index, string match)
         {
            if (_GuiMessageVectorCtrlSetAllowedMatchesFunc == null)
            {
               _GuiMessageVectorCtrlSetAllowedMatchesFunc =
                  (_GuiMessageVectorCtrlSetAllowedMatches)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlSetAllowedMatches"), typeof(_GuiMessageVectorCtrlSetAllowedMatches));
            }

            _GuiMessageVectorCtrlSetAllowedMatchesFunc(ctrl, index, match);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMessageVectorCtrlGetMatchColor(IntPtr ctrl, out Color outColor);
         private static _GuiMessageVectorCtrlGetMatchColor _GuiMessageVectorCtrlGetMatchColorFunc;
         internal static void GuiMessageVectorCtrlGetMatchColor(IntPtr ctrl, out Color outColor)
         {
            if (_GuiMessageVectorCtrlGetMatchColorFunc == null)
            {
               _GuiMessageVectorCtrlGetMatchColorFunc =
                  (_GuiMessageVectorCtrlGetMatchColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlGetMatchColor"), typeof(_GuiMessageVectorCtrlGetMatchColor));
            }

            _GuiMessageVectorCtrlGetMatchColorFunc(ctrl, out outColor);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMessageVectorCtrlSetMatchColor(IntPtr ctrl, Color color);
         private static _GuiMessageVectorCtrlSetMatchColor _GuiMessageVectorCtrlSetMatchColorFunc;
         internal static void GuiMessageVectorCtrlSetMatchColor(IntPtr ctrl, Color color)
         {
            if (_GuiMessageVectorCtrlSetMatchColorFunc == null)
            {
               _GuiMessageVectorCtrlSetMatchColorFunc =
                  (_GuiMessageVectorCtrlSetMatchColor)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlSetMatchColor"), typeof(_GuiMessageVectorCtrlSetMatchColor));
            }

            _GuiMessageVectorCtrlSetMatchColorFunc(ctrl, color);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiMessageVectorCtrlGetMaxColorIndex(IntPtr ctrl);
         private static _GuiMessageVectorCtrlGetMaxColorIndex _GuiMessageVectorCtrlGetMaxColorIndexFunc;
         internal static int GuiMessageVectorCtrlGetMaxColorIndex(IntPtr ctrl)
         {
            if (_GuiMessageVectorCtrlGetMaxColorIndexFunc == null)
            {
               _GuiMessageVectorCtrlGetMaxColorIndexFunc =
                  (_GuiMessageVectorCtrlGetMaxColorIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlGetMaxColorIndex"), typeof(_GuiMessageVectorCtrlGetMaxColorIndex));
            }

            return _GuiMessageVectorCtrlGetMaxColorIndexFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMessageVectorCtrlSetMaxColorIndex(IntPtr ctrl, int index);
         private static _GuiMessageVectorCtrlSetMaxColorIndex _GuiMessageVectorCtrlSetMaxColorIndexFunc;
         internal static void GuiMessageVectorCtrlSetMaxColorIndex(IntPtr ctrl, int index)
         {
            if (_GuiMessageVectorCtrlSetMaxColorIndexFunc == null)
            {
               _GuiMessageVectorCtrlSetMaxColorIndexFunc =
                  (_GuiMessageVectorCtrlSetMaxColorIndex)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlSetMaxColorIndex"), typeof(_GuiMessageVectorCtrlSetMaxColorIndex));
            }

            _GuiMessageVectorCtrlSetMaxColorIndexFunc(ctrl, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMessageVectorCtrlCreateInstance();
         private static _GuiMessageVectorCtrlCreateInstance _GuiMessageVectorCtrlCreateInstanceFunc;
         internal static IntPtr GuiMessageVectorCtrlCreateInstance()
         {
            if (_GuiMessageVectorCtrlCreateInstanceFunc == null)
            {
               _GuiMessageVectorCtrlCreateInstanceFunc =
                  (_GuiMessageVectorCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlCreateInstance"), typeof(_GuiMessageVectorCtrlCreateInstance));
            }

            return _GuiMessageVectorCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiMessageVectorCtrlAttach(IntPtr ctrl, IntPtr MV);
         private static _GuiMessageVectorCtrlAttach _GuiMessageVectorCtrlAttachFunc;
         internal static bool GuiMessageVectorCtrlAttach(IntPtr ctrl, IntPtr MV)
         {
            if (_GuiMessageVectorCtrlAttachFunc == null)
            {
               _GuiMessageVectorCtrlAttachFunc =
                  (_GuiMessageVectorCtrlAttach)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlAttach"), typeof(_GuiMessageVectorCtrlAttach));
            }

            return _GuiMessageVectorCtrlAttachFunc(ctrl, MV);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMessageVectorCtrlDetach(IntPtr ctrl);
         private static _GuiMessageVectorCtrlDetach _GuiMessageVectorCtrlDetachFunc;
         internal static void GuiMessageVectorCtrlDetach(IntPtr ctrl)
         {
            if (_GuiMessageVectorCtrlDetachFunc == null)
            {
               _GuiMessageVectorCtrlDetachFunc =
                  (_GuiMessageVectorCtrlDetach)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMessageVectorCtrlDetach"), typeof(_GuiMessageVectorCtrlDetach));
            }

            _GuiMessageVectorCtrlDetachFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public int LineSpacing
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiMessageVectorCtrlGetLineSpacing(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMessageVectorCtrlSetLineSpacing(ObjectPtr->ObjPtr, value);
         }
      }
      public int LineContinuedIndex
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiMessageVectorCtrlGetLineContinuedIndex(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMessageVectorCtrlSetLineContinuedIndex(ObjectPtr->ObjPtr, value);
         }
      }

      /*public PrimitiveFieldVector<string> AllowedMatches
      {
         get
         {
            return new PrimitiveFieldVector<string>(this, 16, InternalUnsafeMethods.GuiMessageVectorCtrlGetAllowedMatches,
               InternalUnsafeMethods.GuiMessageVectorCtrlSetAllowedMatches);
         }
      }*/
      public Color MatchColor
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            Color outVal;
            InternalUnsafeMethods.GuiMessageVectorCtrlGetMatchColor(ObjectPtr->ObjPtr, out outVal);
            return outVal;
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMessageVectorCtrlSetMatchColor(ObjectPtr->ObjPtr, value);
         }
      }
      public int MaxColorIndex
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiMessageVectorCtrlGetMaxColorIndex(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMessageVectorCtrlSetMaxColorIndex(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool Attach(MessageVector MV)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiMessageVectorCtrlAttach(ObjectPtr->ObjPtr, MV.ObjectPtr->ObjPtr);
      }

      public void Detach()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMessageVectorCtrlDetach(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}