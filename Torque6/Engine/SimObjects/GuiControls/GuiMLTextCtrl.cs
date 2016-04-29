using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiMLTextCtrl : GuiControl
   {
      
      public GuiMLTextCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiMLTextCtrlCreateInstance());
      }

      public GuiMLTextCtrl(uint pId) : base(pId)
      {
      }

      public GuiMLTextCtrl(string pName) : base(pName)
      {
      }

      public GuiMLTextCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMLTextCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiMLTextCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiMLTextCtrlGetLineSpacing(IntPtr ctrl);
         private static _GuiMLTextCtrlGetLineSpacing _GuiMLTextCtrlGetLineSpacingFunc;
         internal static int GuiMLTextCtrlGetLineSpacing(IntPtr ctrl)
         {
            if (_GuiMLTextCtrlGetLineSpacingFunc == null)
            {
               _GuiMLTextCtrlGetLineSpacingFunc =
                  (_GuiMLTextCtrlGetLineSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlGetLineSpacing"), typeof(_GuiMLTextCtrlGetLineSpacing));
            }

            return _GuiMLTextCtrlGetLineSpacingFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlSetLineSpacing(IntPtr ctrl, int spacing);
         private static _GuiMLTextCtrlSetLineSpacing _GuiMLTextCtrlSetLineSpacingFunc;
         internal static void GuiMLTextCtrlSetLineSpacing(IntPtr ctrl, int spacing)
         {
            if (_GuiMLTextCtrlSetLineSpacingFunc == null)
            {
               _GuiMLTextCtrlSetLineSpacingFunc =
                  (_GuiMLTextCtrlSetLineSpacing)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlSetLineSpacing"), typeof(_GuiMLTextCtrlSetLineSpacing));
            }

            _GuiMLTextCtrlSetLineSpacingFunc(ctrl, spacing);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiMLTextCtrlGetAllowColorChars(IntPtr ctrl);
         private static _GuiMLTextCtrlGetAllowColorChars _GuiMLTextCtrlGetAllowColorCharsFunc;
         internal static bool GuiMLTextCtrlGetAllowColorChars(IntPtr ctrl)
         {
            if (_GuiMLTextCtrlGetAllowColorCharsFunc == null)
            {
               _GuiMLTextCtrlGetAllowColorCharsFunc =
                  (_GuiMLTextCtrlGetAllowColorChars)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlGetAllowColorChars"), typeof(_GuiMLTextCtrlGetAllowColorChars));
            }

            return _GuiMLTextCtrlGetAllowColorCharsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlSetAllowColorChars(IntPtr ctrl, bool allow);
         private static _GuiMLTextCtrlSetAllowColorChars _GuiMLTextCtrlSetAllowColorCharsFunc;
         internal static void GuiMLTextCtrlSetAllowColorChars(IntPtr ctrl, bool allow)
         {
            if (_GuiMLTextCtrlSetAllowColorCharsFunc == null)
            {
               _GuiMLTextCtrlSetAllowColorCharsFunc =
                  (_GuiMLTextCtrlSetAllowColorChars)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlSetAllowColorChars"), typeof(_GuiMLTextCtrlSetAllowColorChars));
            }

            _GuiMLTextCtrlSetAllowColorCharsFunc(ctrl, allow);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiMLTextCtrlGetMaxChars(IntPtr ctrl);
         private static _GuiMLTextCtrlGetMaxChars _GuiMLTextCtrlGetMaxCharsFunc;
         internal static int GuiMLTextCtrlGetMaxChars(IntPtr ctrl)
         {
            if (_GuiMLTextCtrlGetMaxCharsFunc == null)
            {
               _GuiMLTextCtrlGetMaxCharsFunc =
                  (_GuiMLTextCtrlGetMaxChars)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlGetMaxChars"), typeof(_GuiMLTextCtrlGetMaxChars));
            }

            return _GuiMLTextCtrlGetMaxCharsFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlSetMaxChars(IntPtr ctrl, int count);
         private static _GuiMLTextCtrlSetMaxChars _GuiMLTextCtrlSetMaxCharsFunc;
         internal static void GuiMLTextCtrlSetMaxChars(IntPtr ctrl, int count)
         {
            if (_GuiMLTextCtrlSetMaxCharsFunc == null)
            {
               _GuiMLTextCtrlSetMaxCharsFunc =
                  (_GuiMLTextCtrlSetMaxChars)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlSetMaxChars"), typeof(_GuiMLTextCtrlSetMaxChars));
            }

            _GuiMLTextCtrlSetMaxCharsFunc(ctrl, count);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMLTextCtrlGetDeniedSound(IntPtr ctrl);
         private static _GuiMLTextCtrlGetDeniedSound _GuiMLTextCtrlGetDeniedSoundFunc;
         internal static IntPtr GuiMLTextCtrlGetDeniedSound(IntPtr ctrl)
         {
            if (_GuiMLTextCtrlGetDeniedSoundFunc == null)
            {
               _GuiMLTextCtrlGetDeniedSoundFunc =
                  (_GuiMLTextCtrlGetDeniedSound)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlGetDeniedSound"), typeof(_GuiMLTextCtrlGetDeniedSound));
            }

            return _GuiMLTextCtrlGetDeniedSoundFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlSetDeniedSound(IntPtr ctrl, IntPtr sound);
         private static _GuiMLTextCtrlSetDeniedSound _GuiMLTextCtrlSetDeniedSoundFunc;
         internal static void GuiMLTextCtrlSetDeniedSound(IntPtr ctrl, IntPtr sound)
         {
            if (_GuiMLTextCtrlSetDeniedSoundFunc == null)
            {
               _GuiMLTextCtrlSetDeniedSoundFunc =
                  (_GuiMLTextCtrlSetDeniedSound)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlSetDeniedSound"), typeof(_GuiMLTextCtrlSetDeniedSound));
            }

            _GuiMLTextCtrlSetDeniedSoundFunc(ctrl, sound);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMLTextCtrlGetText(IntPtr ctrl);
         private static _GuiMLTextCtrlGetText _GuiMLTextCtrlGetTextFunc;
         internal static IntPtr GuiMLTextCtrlGetText(IntPtr ctrl)
         {
            if (_GuiMLTextCtrlGetTextFunc == null)
            {
               _GuiMLTextCtrlGetTextFunc =
                  (_GuiMLTextCtrlGetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlGetText"), typeof(_GuiMLTextCtrlGetText));
            }

            return _GuiMLTextCtrlGetTextFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlSetText(IntPtr ctrl, string text);
         private static _GuiMLTextCtrlSetText _GuiMLTextCtrlSetTextFunc;
         internal static void GuiMLTextCtrlSetText(IntPtr ctrl, string text)
         {
            if (_GuiMLTextCtrlSetTextFunc == null)
            {
               _GuiMLTextCtrlSetTextFunc =
                  (_GuiMLTextCtrlSetText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlSetText"), typeof(_GuiMLTextCtrlSetText));
            }

            _GuiMLTextCtrlSetTextFunc(ctrl, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMLTextCtrlCreateInstance();
         private static _GuiMLTextCtrlCreateInstance _GuiMLTextCtrlCreateInstanceFunc;
         internal static IntPtr GuiMLTextCtrlCreateInstance()
         {
            if (_GuiMLTextCtrlCreateInstanceFunc == null)
            {
               _GuiMLTextCtrlCreateInstanceFunc =
                  (_GuiMLTextCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlCreateInstance"), typeof(_GuiMLTextCtrlCreateInstance));
            }

            return _GuiMLTextCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlSetCurrentText(IntPtr ctrl, string text);
         private static _GuiMLTextCtrlSetCurrentText _GuiMLTextCtrlSetCurrentTextFunc;
         internal static void GuiMLTextCtrlSetCurrentText(IntPtr ctrl, string text)
         {
            if (_GuiMLTextCtrlSetCurrentTextFunc == null)
            {
               _GuiMLTextCtrlSetCurrentTextFunc =
                  (_GuiMLTextCtrlSetCurrentText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlSetCurrentText"), typeof(_GuiMLTextCtrlSetCurrentText));
            }

            _GuiMLTextCtrlSetCurrentTextFunc(ctrl, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMLTextCtrlGetCurrentText(IntPtr ctrl);
         private static _GuiMLTextCtrlGetCurrentText _GuiMLTextCtrlGetCurrentTextFunc;
         internal static IntPtr GuiMLTextCtrlGetCurrentText(IntPtr ctrl)
         {
            if (_GuiMLTextCtrlGetCurrentTextFunc == null)
            {
               _GuiMLTextCtrlGetCurrentTextFunc =
                  (_GuiMLTextCtrlGetCurrentText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlGetCurrentText"), typeof(_GuiMLTextCtrlGetCurrentText));
            }

            return _GuiMLTextCtrlGetCurrentTextFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlAddText(IntPtr ctrl, string text, bool reformat);
         private static _GuiMLTextCtrlAddText _GuiMLTextCtrlAddTextFunc;
         internal static void GuiMLTextCtrlAddText(IntPtr ctrl, string text, bool reformat)
         {
            if (_GuiMLTextCtrlAddTextFunc == null)
            {
               _GuiMLTextCtrlAddTextFunc =
                  (_GuiMLTextCtrlAddText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlAddText"), typeof(_GuiMLTextCtrlAddText));
            }

            _GuiMLTextCtrlAddTextFunc(ctrl, text, reformat);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiMLTextCtrlSetCursorPosition(IntPtr ctrl, int newPos);
         private static _GuiMLTextCtrlSetCursorPosition _GuiMLTextCtrlSetCursorPositionFunc;
         internal static bool GuiMLTextCtrlSetCursorPosition(IntPtr ctrl, int newPos)
         {
            if (_GuiMLTextCtrlSetCursorPositionFunc == null)
            {
               _GuiMLTextCtrlSetCursorPositionFunc =
                  (_GuiMLTextCtrlSetCursorPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlSetCursorPosition"), typeof(_GuiMLTextCtrlSetCursorPosition));
            }

            return _GuiMLTextCtrlSetCursorPositionFunc(ctrl, newPos);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlScrollToTag(IntPtr ctrl, int tagID);
         private static _GuiMLTextCtrlScrollToTag _GuiMLTextCtrlScrollToTagFunc;
         internal static void GuiMLTextCtrlScrollToTag(IntPtr ctrl, int tagID)
         {
            if (_GuiMLTextCtrlScrollToTagFunc == null)
            {
               _GuiMLTextCtrlScrollToTagFunc =
                  (_GuiMLTextCtrlScrollToTag)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlScrollToTag"), typeof(_GuiMLTextCtrlScrollToTag));
            }

            _GuiMLTextCtrlScrollToTagFunc(ctrl, tagID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlScrollToBottom(IntPtr ctrl);
         private static _GuiMLTextCtrlScrollToBottom _GuiMLTextCtrlScrollToBottomFunc;
         internal static void GuiMLTextCtrlScrollToBottom(IntPtr ctrl)
         {
            if (_GuiMLTextCtrlScrollToBottomFunc == null)
            {
               _GuiMLTextCtrlScrollToBottomFunc =
                  (_GuiMLTextCtrlScrollToBottom)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlScrollToBottom"), typeof(_GuiMLTextCtrlScrollToBottom));
            }

            _GuiMLTextCtrlScrollToBottomFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlScrollToTop(IntPtr ctrl);
         private static _GuiMLTextCtrlScrollToTop _GuiMLTextCtrlScrollToTopFunc;
         internal static void GuiMLTextCtrlScrollToTop(IntPtr ctrl)
         {
            if (_GuiMLTextCtrlScrollToTopFunc == null)
            {
               _GuiMLTextCtrlScrollToTopFunc =
                  (_GuiMLTextCtrlScrollToTop)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlScrollToTop"), typeof(_GuiMLTextCtrlScrollToTop));
            }

            _GuiMLTextCtrlScrollToTopFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlForceReflow(IntPtr ctrl);
         private static _GuiMLTextCtrlForceReflow _GuiMLTextCtrlForceReflowFunc;
         internal static void GuiMLTextCtrlForceReflow(IntPtr ctrl)
         {
            if (_GuiMLTextCtrlForceReflowFunc == null)
            {
               _GuiMLTextCtrlForceReflowFunc =
                  (_GuiMLTextCtrlForceReflow)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlForceReflow"), typeof(_GuiMLTextCtrlForceReflow));
            }

            _GuiMLTextCtrlForceReflowFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiMLTextCtrlSetAlpha(IntPtr ctrl, float alpha);
         private static _GuiMLTextCtrlSetAlpha _GuiMLTextCtrlSetAlphaFunc;
         internal static void GuiMLTextCtrlSetAlpha(IntPtr ctrl, float alpha)
         {
            if (_GuiMLTextCtrlSetAlphaFunc == null)
            {
               _GuiMLTextCtrlSetAlphaFunc =
                  (_GuiMLTextCtrlSetAlpha)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiMLTextCtrlSetAlpha"), typeof(_GuiMLTextCtrlSetAlpha));
            }

            _GuiMLTextCtrlSetAlphaFunc(ctrl, alpha);
         }
      }
      
      #endregion

      #region Properties

      public int LineSpacing
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiMLTextCtrlGetLineSpacing(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMLTextCtrlSetLineSpacing(ObjectPtr->ObjPtr, value);
         }
      }
      public bool AllowColorChars
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiMLTextCtrlGetAllowColorChars(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMLTextCtrlSetAllowColorChars(ObjectPtr->ObjPtr, value);
         }
      }
      public int MaxChars
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiMLTextCtrlGetMaxChars(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMLTextCtrlSetMaxChars(ObjectPtr->ObjPtr, value);
         }
      }
      public AudioAsset DeniedSound
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return new AudioAsset(InternalUnsafeMethods.GuiMLTextCtrlGetDeniedSound(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMLTextCtrlSetDeniedSound(ObjectPtr->ObjPtr, value.ObjectPtr->ObjPtr);
         }
      }
      public string Text
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiMLTextCtrlGetText(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiMLTextCtrlSetText(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void SetCurrentText(string text)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMLTextCtrlSetCurrentText(ObjectPtr->ObjPtr, text);
      }

      public string GetCurrentText()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiMLTextCtrlGetCurrentText(ObjectPtr->ObjPtr));
      }

      public void AddText(string text, bool reformat)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMLTextCtrlAddText(ObjectPtr->ObjPtr, text, reformat);
      }

      public bool SetCursorPosition(int newPos)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiMLTextCtrlSetCursorPosition(ObjectPtr->ObjPtr, newPos);
      }

      public void ScrollToTag(int tagID)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMLTextCtrlScrollToTag(ObjectPtr->ObjPtr, tagID);
      }

      public void ScrollToBottom()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMLTextCtrlScrollToBottom(ObjectPtr->ObjPtr);
      }

      public void ScrollToTop()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMLTextCtrlScrollToTop(ObjectPtr->ObjPtr);
      }

      public void ForceReflow()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMLTextCtrlForceReflow(ObjectPtr->ObjPtr);
      }

      public void SetAlpha(float alpha)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiMLTextCtrlSetAlpha(ObjectPtr->ObjPtr, alpha);
      }
      
      #endregion

      
   }
}