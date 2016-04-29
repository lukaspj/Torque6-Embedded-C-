using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiTextEditCtrl : GuiTextCtrl
   {
      
      public GuiTextEditCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiTextEditCtrlCreateInstance());
      }

      public GuiTextEditCtrl(uint pId) : base(pId)
      {
      }

      public GuiTextEditCtrl(string pName) : base(pName)
      {
      }

      public GuiTextEditCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTextEditCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiTextEditCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditCtrlGetValidate(IntPtr ctrl);
         private static _GuiTextEditCtrlGetValidate _GuiTextEditCtrlGetValidateFunc;
         internal static IntPtr GuiTextEditCtrlGetValidate(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetValidateFunc == null)
            {
               _GuiTextEditCtrlGetValidateFunc =
                  (_GuiTextEditCtrlGetValidate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetValidate"), typeof(_GuiTextEditCtrlGetValidate));
            }

            return _GuiTextEditCtrlGetValidateFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSetValidate(IntPtr ctrl, string validateCommand);
         private static _GuiTextEditCtrlSetValidate _GuiTextEditCtrlSetValidateFunc;
         internal static void GuiTextEditCtrlSetValidate(IntPtr ctrl, string validateCommand)
         {
            if (_GuiTextEditCtrlSetValidateFunc == null)
            {
               _GuiTextEditCtrlSetValidateFunc =
                  (_GuiTextEditCtrlSetValidate)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSetValidate"), typeof(_GuiTextEditCtrlSetValidate));
            }

            _GuiTextEditCtrlSetValidateFunc(ctrl, validateCommand);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditCtrlGetEscapeCommand(IntPtr ctrl);
         private static _GuiTextEditCtrlGetEscapeCommand _GuiTextEditCtrlGetEscapeCommandFunc;
         internal static IntPtr GuiTextEditCtrlGetEscapeCommand(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetEscapeCommandFunc == null)
            {
               _GuiTextEditCtrlGetEscapeCommandFunc =
                  (_GuiTextEditCtrlGetEscapeCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetEscapeCommand"), typeof(_GuiTextEditCtrlGetEscapeCommand));
            }

            return _GuiTextEditCtrlGetEscapeCommandFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSetEscapeCommand(IntPtr ctrl, string EscapeCommand);
         private static _GuiTextEditCtrlSetEscapeCommand _GuiTextEditCtrlSetEscapeCommandFunc;
         internal static void GuiTextEditCtrlSetEscapeCommand(IntPtr ctrl, string EscapeCommand)
         {
            if (_GuiTextEditCtrlSetEscapeCommandFunc == null)
            {
               _GuiTextEditCtrlSetEscapeCommandFunc =
                  (_GuiTextEditCtrlSetEscapeCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSetEscapeCommand"), typeof(_GuiTextEditCtrlSetEscapeCommand));
            }

            _GuiTextEditCtrlSetEscapeCommandFunc(ctrl, EscapeCommand);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTextEditCtrlGetHistorySize(IntPtr ctrl);
         private static _GuiTextEditCtrlGetHistorySize _GuiTextEditCtrlGetHistorySizeFunc;
         internal static int GuiTextEditCtrlGetHistorySize(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetHistorySizeFunc == null)
            {
               _GuiTextEditCtrlGetHistorySizeFunc =
                  (_GuiTextEditCtrlGetHistorySize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetHistorySize"), typeof(_GuiTextEditCtrlGetHistorySize));
            }

            return _GuiTextEditCtrlGetHistorySizeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSetHistorySize(IntPtr ctrl, int size);
         private static _GuiTextEditCtrlSetHistorySize _GuiTextEditCtrlSetHistorySizeFunc;
         internal static void GuiTextEditCtrlSetHistorySize(IntPtr ctrl, int size)
         {
            if (_GuiTextEditCtrlSetHistorySizeFunc == null)
            {
               _GuiTextEditCtrlSetHistorySizeFunc =
                  (_GuiTextEditCtrlSetHistorySize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSetHistorySize"), typeof(_GuiTextEditCtrlSetHistorySize));
            }

            _GuiTextEditCtrlSetHistorySizeFunc(ctrl, size);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTextEditCtrlGetTabComplete(IntPtr ctrl);
         private static _GuiTextEditCtrlGetTabComplete _GuiTextEditCtrlGetTabCompleteFunc;
         internal static bool GuiTextEditCtrlGetTabComplete(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetTabCompleteFunc == null)
            {
               _GuiTextEditCtrlGetTabCompleteFunc =
                  (_GuiTextEditCtrlGetTabComplete)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetTabComplete"), typeof(_GuiTextEditCtrlGetTabComplete));
            }

            return _GuiTextEditCtrlGetTabCompleteFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSetTabComplete(IntPtr ctrl, bool tabComplete);
         private static _GuiTextEditCtrlSetTabComplete _GuiTextEditCtrlSetTabCompleteFunc;
         internal static void GuiTextEditCtrlSetTabComplete(IntPtr ctrl, bool tabComplete)
         {
            if (_GuiTextEditCtrlSetTabCompleteFunc == null)
            {
               _GuiTextEditCtrlSetTabCompleteFunc =
                  (_GuiTextEditCtrlSetTabComplete)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSetTabComplete"), typeof(_GuiTextEditCtrlSetTabComplete));
            }

            _GuiTextEditCtrlSetTabCompleteFunc(ctrl, tabComplete);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditCtrlGetDeniedSound(IntPtr ctrl);
         private static _GuiTextEditCtrlGetDeniedSound _GuiTextEditCtrlGetDeniedSoundFunc;
         internal static IntPtr GuiTextEditCtrlGetDeniedSound(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetDeniedSoundFunc == null)
            {
               _GuiTextEditCtrlGetDeniedSoundFunc =
                  (_GuiTextEditCtrlGetDeniedSound)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetDeniedSound"), typeof(_GuiTextEditCtrlGetDeniedSound));
            }

            return _GuiTextEditCtrlGetDeniedSoundFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSetDeniedSound(IntPtr ctrl, IntPtr sound);
         private static _GuiTextEditCtrlSetDeniedSound _GuiTextEditCtrlSetDeniedSoundFunc;
         internal static void GuiTextEditCtrlSetDeniedSound(IntPtr ctrl, IntPtr sound)
         {
            if (_GuiTextEditCtrlSetDeniedSoundFunc == null)
            {
               _GuiTextEditCtrlSetDeniedSoundFunc =
                  (_GuiTextEditCtrlSetDeniedSound)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSetDeniedSound"), typeof(_GuiTextEditCtrlSetDeniedSound));
            }

            _GuiTextEditCtrlSetDeniedSoundFunc(ctrl, sound);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTextEditCtrlGetSinkAllKeyEvents(IntPtr ctrl);
         private static _GuiTextEditCtrlGetSinkAllKeyEvents _GuiTextEditCtrlGetSinkAllKeyEventsFunc;
         internal static bool GuiTextEditCtrlGetSinkAllKeyEvents(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetSinkAllKeyEventsFunc == null)
            {
               _GuiTextEditCtrlGetSinkAllKeyEventsFunc =
                  (_GuiTextEditCtrlGetSinkAllKeyEvents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetSinkAllKeyEvents"), typeof(_GuiTextEditCtrlGetSinkAllKeyEvents));
            }

            return _GuiTextEditCtrlGetSinkAllKeyEventsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSetSinkAllKeyEvents(IntPtr ctrl, bool sinkAllKeyEvents);
         private static _GuiTextEditCtrlSetSinkAllKeyEvents _GuiTextEditCtrlSetSinkAllKeyEventsFunc;
         internal static void GuiTextEditCtrlSetSinkAllKeyEvents(IntPtr ctrl, bool sinkAllKeyEvents)
         {
            if (_GuiTextEditCtrlSetSinkAllKeyEventsFunc == null)
            {
               _GuiTextEditCtrlSetSinkAllKeyEventsFunc =
                  (_GuiTextEditCtrlSetSinkAllKeyEvents)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSetSinkAllKeyEvents"), typeof(_GuiTextEditCtrlSetSinkAllKeyEvents));
            }

            _GuiTextEditCtrlSetSinkAllKeyEventsFunc(ctrl, sinkAllKeyEvents);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiTextEditCtrlGetPassword(IntPtr ctrl);
         private static _GuiTextEditCtrlGetPassword _GuiTextEditCtrlGetPasswordFunc;
         internal static bool GuiTextEditCtrlGetPassword(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetPasswordFunc == null)
            {
               _GuiTextEditCtrlGetPasswordFunc =
                  (_GuiTextEditCtrlGetPassword)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetPassword"), typeof(_GuiTextEditCtrlGetPassword));
            }

            return _GuiTextEditCtrlGetPasswordFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSetPassword(IntPtr ctrl, bool isPasswordText);
         private static _GuiTextEditCtrlSetPassword _GuiTextEditCtrlSetPasswordFunc;
         internal static void GuiTextEditCtrlSetPassword(IntPtr ctrl, bool isPasswordText)
         {
            if (_GuiTextEditCtrlSetPasswordFunc == null)
            {
               _GuiTextEditCtrlSetPasswordFunc =
                  (_GuiTextEditCtrlSetPassword)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSetPassword"), typeof(_GuiTextEditCtrlSetPassword));
            }

            _GuiTextEditCtrlSetPasswordFunc(ctrl, isPasswordText);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditCtrlGetPasswordMask(IntPtr ctrl);
         private static _GuiTextEditCtrlGetPasswordMask _GuiTextEditCtrlGetPasswordMaskFunc;
         internal static IntPtr GuiTextEditCtrlGetPasswordMask(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetPasswordMaskFunc == null)
            {
               _GuiTextEditCtrlGetPasswordMaskFunc =
                  (_GuiTextEditCtrlGetPasswordMask)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetPasswordMask"), typeof(_GuiTextEditCtrlGetPasswordMask));
            }

            return _GuiTextEditCtrlGetPasswordMaskFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSetPasswordMask(IntPtr ctrl, string PasswordMaskCommand);
         private static _GuiTextEditCtrlSetPasswordMask _GuiTextEditCtrlSetPasswordMaskFunc;
         internal static void GuiTextEditCtrlSetPasswordMask(IntPtr ctrl, string PasswordMaskCommand)
         {
            if (_GuiTextEditCtrlSetPasswordMaskFunc == null)
            {
               _GuiTextEditCtrlSetPasswordMaskFunc =
                  (_GuiTextEditCtrlSetPasswordMask)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSetPasswordMask"), typeof(_GuiTextEditCtrlSetPasswordMask));
            }

            _GuiTextEditCtrlSetPasswordMaskFunc(ctrl, PasswordMaskCommand);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditCtrlCreateInstance();
         private static _GuiTextEditCtrlCreateInstance _GuiTextEditCtrlCreateInstanceFunc;
         internal static IntPtr GuiTextEditCtrlCreateInstance()
         {
            if (_GuiTextEditCtrlCreateInstanceFunc == null)
            {
               _GuiTextEditCtrlCreateInstanceFunc =
                  (_GuiTextEditCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlCreateInstance"), typeof(_GuiTextEditCtrlCreateInstance));
            }

            return _GuiTextEditCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTextEditCtrlGetText(IntPtr ctrl);
         private static _GuiTextEditCtrlGetText _GuiTextEditCtrlGetTextFunc;
         internal static IntPtr GuiTextEditCtrlGetText(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetTextFunc == null)
            {
               _GuiTextEditCtrlGetTextFunc =
                  (_GuiTextEditCtrlGetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetText"), typeof(_GuiTextEditCtrlGetText));
            }

            return _GuiTextEditCtrlGetTextFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiTextEditCtrlGetCursorPos(IntPtr ctrl);
         private static _GuiTextEditCtrlGetCursorPos _GuiTextEditCtrlGetCursorPosFunc;
         internal static int GuiTextEditCtrlGetCursorPos(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlGetCursorPosFunc == null)
            {
               _GuiTextEditCtrlGetCursorPosFunc =
                  (_GuiTextEditCtrlGetCursorPos)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlGetCursorPos"), typeof(_GuiTextEditCtrlGetCursorPos));
            }

            return _GuiTextEditCtrlGetCursorPosFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSetCursorPos(IntPtr ctrl, int newPos);
         private static _GuiTextEditCtrlSetCursorPos _GuiTextEditCtrlSetCursorPosFunc;
         internal static void GuiTextEditCtrlSetCursorPos(IntPtr ctrl, int newPos)
         {
            if (_GuiTextEditCtrlSetCursorPosFunc == null)
            {
               _GuiTextEditCtrlSetCursorPosFunc =
                  (_GuiTextEditCtrlSetCursorPos)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSetCursorPos"), typeof(_GuiTextEditCtrlSetCursorPos));
            }

            _GuiTextEditCtrlSetCursorPosFunc(ctrl, newPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlSelectAllText(IntPtr ctrl);
         private static _GuiTextEditCtrlSelectAllText _GuiTextEditCtrlSelectAllTextFunc;
         internal static void GuiTextEditCtrlSelectAllText(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlSelectAllTextFunc == null)
            {
               _GuiTextEditCtrlSelectAllTextFunc =
                  (_GuiTextEditCtrlSelectAllText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlSelectAllText"), typeof(_GuiTextEditCtrlSelectAllText));
            }

            _GuiTextEditCtrlSelectAllTextFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiTextEditCtrlForceValidateText(IntPtr ctrl);
         private static _GuiTextEditCtrlForceValidateText _GuiTextEditCtrlForceValidateTextFunc;
         internal static void GuiTextEditCtrlForceValidateText(IntPtr ctrl)
         {
            if (_GuiTextEditCtrlForceValidateTextFunc == null)
            {
               _GuiTextEditCtrlForceValidateTextFunc =
                  (_GuiTextEditCtrlForceValidateText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiTextEditCtrlForceValidateText"), typeof(_GuiTextEditCtrlForceValidateText));
            }

            _GuiTextEditCtrlForceValidateTextFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public string Validate
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTextEditCtrlGetValidate(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditCtrlSetValidate(ObjectPtr->ObjPtr, value);
         }
      }
      public string EscapeCommand
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTextEditCtrlGetEscapeCommand(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditCtrlSetEscapeCommand(ObjectPtr->ObjPtr, value);
         }
      }
      public int HistorySize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextEditCtrlGetHistorySize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditCtrlSetHistorySize(ObjectPtr->ObjPtr, value);
         }
      }
      public bool TabComplete
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextEditCtrlGetTabComplete(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditCtrlSetTabComplete(ObjectPtr->ObjPtr, value);
         }
      }
      public AudioAsset DeniedSound
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new AudioAsset(InternalUnsafeMethods.GuiTextEditCtrlGetDeniedSound(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditCtrlSetDeniedSound(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      public bool SinkAllKeyEvents
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextEditCtrlGetSinkAllKeyEvents(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditCtrlSetSinkAllKeyEvents(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Password
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiTextEditCtrlGetPassword(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditCtrlSetPassword(ObjectPtr->ObjPtr, value);
         }
      }
      public string PasswordMask
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTextEditCtrlGetPasswordMask(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiTextEditCtrlSetPasswordMask(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public string GetText()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiTextEditCtrlGetText(ObjectPtr->ObjPtr));
      }

      public int GetCursorPos()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiTextEditCtrlGetCursorPos(ObjectPtr->ObjPtr);
      }

      public void SetCursorPos(int newPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextEditCtrlSetCursorPos(ObjectPtr->ObjPtr, newPos);
      }

      public void SelectAllText()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextEditCtrlSelectAllText(ObjectPtr->ObjPtr);
      }

      public void ForceValidateText()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiTextEditCtrlForceValidateText(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}