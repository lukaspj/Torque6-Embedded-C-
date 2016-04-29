using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiPaneControl : GuiControl
   {
      
      public GuiPaneControl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiPaneControlCreateInstance());
      }

      public GuiPaneControl(uint pId) : base(pId)
      {
      }

      public GuiPaneControl(string pName) : base(pName)
      {
      }

      public GuiPaneControl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPaneControl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiPaneControl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiPaneControlGetCaption(IntPtr ctrl);
         private static _GuiPaneControlGetCaption _GuiPaneControlGetCaptionFunc;
         internal static IntPtr GuiPaneControlGetCaption(IntPtr ctrl)
         {
            if (_GuiPaneControlGetCaptionFunc == null)
            {
               _GuiPaneControlGetCaptionFunc =
                  (_GuiPaneControlGetCaption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlGetCaption"), typeof(_GuiPaneControlGetCaption));
            }

            return _GuiPaneControlGetCaptionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPaneControlSetCaption(IntPtr ctrl, string caption);
         private static _GuiPaneControlSetCaption _GuiPaneControlSetCaptionFunc;
         internal static void GuiPaneControlSetCaption(IntPtr ctrl, string caption)
         {
            if (_GuiPaneControlSetCaptionFunc == null)
            {
               _GuiPaneControlSetCaptionFunc =
                  (_GuiPaneControlSetCaption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlSetCaption"), typeof(_GuiPaneControlSetCaption));
            }

            _GuiPaneControlSetCaptionFunc(ctrl, caption);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiPaneControlGetCaptionID(IntPtr ctrl);
         private static _GuiPaneControlGetCaptionID _GuiPaneControlGetCaptionIDFunc;
         internal static IntPtr GuiPaneControlGetCaptionID(IntPtr ctrl)
         {
            if (_GuiPaneControlGetCaptionIDFunc == null)
            {
               _GuiPaneControlGetCaptionIDFunc =
                  (_GuiPaneControlGetCaptionID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlGetCaptionID"), typeof(_GuiPaneControlGetCaptionID));
            }

            return _GuiPaneControlGetCaptionIDFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPaneControlSetCaptionID(IntPtr ctrl, string captionID);
         private static _GuiPaneControlSetCaptionID _GuiPaneControlSetCaptionIDFunc;
         internal static void GuiPaneControlSetCaptionID(IntPtr ctrl, string captionID)
         {
            if (_GuiPaneControlSetCaptionIDFunc == null)
            {
               _GuiPaneControlSetCaptionIDFunc =
                  (_GuiPaneControlSetCaptionID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlSetCaptionID"), typeof(_GuiPaneControlSetCaptionID));
            }

            _GuiPaneControlSetCaptionIDFunc(ctrl, captionID);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiPaneControlGetCollapsable(IntPtr ctrl);
         private static _GuiPaneControlGetCollapsable _GuiPaneControlGetCollapsableFunc;
         internal static bool GuiPaneControlGetCollapsable(IntPtr ctrl)
         {
            if (_GuiPaneControlGetCollapsableFunc == null)
            {
               _GuiPaneControlGetCollapsableFunc =
                  (_GuiPaneControlGetCollapsable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlGetCollapsable"), typeof(_GuiPaneControlGetCollapsable));
            }

            return _GuiPaneControlGetCollapsableFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPaneControlSetCollapsable(IntPtr ctrl, bool collapsable);
         private static _GuiPaneControlSetCollapsable _GuiPaneControlSetCollapsableFunc;
         internal static void GuiPaneControlSetCollapsable(IntPtr ctrl, bool collapsable)
         {
            if (_GuiPaneControlSetCollapsableFunc == null)
            {
               _GuiPaneControlSetCollapsableFunc =
                  (_GuiPaneControlSetCollapsable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlSetCollapsable"), typeof(_GuiPaneControlSetCollapsable));
            }

            _GuiPaneControlSetCollapsableFunc(ctrl, collapsable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiPaneControlGetBarBehindText(IntPtr ctrl);
         private static _GuiPaneControlGetBarBehindText _GuiPaneControlGetBarBehindTextFunc;
         internal static bool GuiPaneControlGetBarBehindText(IntPtr ctrl)
         {
            if (_GuiPaneControlGetBarBehindTextFunc == null)
            {
               _GuiPaneControlGetBarBehindTextFunc =
                  (_GuiPaneControlGetBarBehindText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlGetBarBehindText"), typeof(_GuiPaneControlGetBarBehindText));
            }

            return _GuiPaneControlGetBarBehindTextFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPaneControlSetBarBehindText(IntPtr ctrl, bool enable);
         private static _GuiPaneControlSetBarBehindText _GuiPaneControlSetBarBehindTextFunc;
         internal static void GuiPaneControlSetBarBehindText(IntPtr ctrl, bool enable)
         {
            if (_GuiPaneControlSetBarBehindTextFunc == null)
            {
               _GuiPaneControlSetBarBehindTextFunc =
                  (_GuiPaneControlSetBarBehindText)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlSetBarBehindText"), typeof(_GuiPaneControlSetBarBehindText));
            }

            _GuiPaneControlSetBarBehindTextFunc(ctrl, enable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiPaneControlCreateInstance();
         private static _GuiPaneControlCreateInstance _GuiPaneControlCreateInstanceFunc;
         internal static IntPtr GuiPaneControlCreateInstance()
         {
            if (_GuiPaneControlCreateInstanceFunc == null)
            {
               _GuiPaneControlCreateInstanceFunc =
                  (_GuiPaneControlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlCreateInstance"), typeof(_GuiPaneControlCreateInstance));
            }

            return _GuiPaneControlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiPaneControlSetCollapsed(IntPtr ctrl, bool collapsed);
         private static _GuiPaneControlSetCollapsed _GuiPaneControlSetCollapsedFunc;
         internal static void GuiPaneControlSetCollapsed(IntPtr ctrl, bool collapsed)
         {
            if (_GuiPaneControlSetCollapsedFunc == null)
            {
               _GuiPaneControlSetCollapsedFunc =
                  (_GuiPaneControlSetCollapsed)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiPaneControlSetCollapsed"), typeof(_GuiPaneControlSetCollapsed));
            }

            _GuiPaneControlSetCollapsedFunc(ctrl, collapsed);
         }
      }
      
      #endregion

      #region Properties

      public string Caption
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiPaneControlGetCaption(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiPaneControlSetCaption(ObjectPtr->ObjPtr, value);
         }
      }
      public string CaptionID
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiPaneControlGetCaptionID(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiPaneControlSetCaptionID(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Collapsable
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiPaneControlGetCollapsable(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiPaneControlSetCollapsable(ObjectPtr->ObjPtr, value);
         }
      }
      public bool BarBehindText
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiPaneControlGetBarBehindText(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiPaneControlSetBarBehindText(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public void SetCollapsed(bool collapsed)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.GuiPaneControlSetCollapsed(ObjectPtr->ObjPtr, collapsed);
      }
      
      #endregion

      
   }
}