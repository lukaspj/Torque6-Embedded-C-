using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiScriptNotifyCtrl : GuiControl
   {
      
      public GuiScriptNotifyCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiScriptNotifyCtrlCreateInstance());
      }

      public GuiScriptNotifyCtrl(uint pId) : base(pId)
      {
      }

      public GuiScriptNotifyCtrl(string pName) : base(pName)
      {
      }

      public GuiScriptNotifyCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiScriptNotifyCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiScriptNotifyCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScriptNotifyCtrlGetOnChildAdded(IntPtr ctrl);
         private static _GuiScriptNotifyCtrlGetOnChildAdded _GuiScriptNotifyCtrlGetOnChildAddedFunc;
         internal static bool GuiScriptNotifyCtrlGetOnChildAdded(IntPtr ctrl)
         {
            if (_GuiScriptNotifyCtrlGetOnChildAddedFunc == null)
            {
               _GuiScriptNotifyCtrlGetOnChildAddedFunc =
                  (_GuiScriptNotifyCtrlGetOnChildAdded)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlGetOnChildAdded"), typeof(_GuiScriptNotifyCtrlGetOnChildAdded));
            }

            return _GuiScriptNotifyCtrlGetOnChildAddedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScriptNotifyCtrlSetOnChildAdded(IntPtr ctrl, bool value);
         private static _GuiScriptNotifyCtrlSetOnChildAdded _GuiScriptNotifyCtrlSetOnChildAddedFunc;
         internal static void GuiScriptNotifyCtrlSetOnChildAdded(IntPtr ctrl, bool value)
         {
            if (_GuiScriptNotifyCtrlSetOnChildAddedFunc == null)
            {
               _GuiScriptNotifyCtrlSetOnChildAddedFunc =
                  (_GuiScriptNotifyCtrlSetOnChildAdded)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlSetOnChildAdded"), typeof(_GuiScriptNotifyCtrlSetOnChildAdded));
            }

            _GuiScriptNotifyCtrlSetOnChildAddedFunc(ctrl, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScriptNotifyCtrlGetOnChildRemoved(IntPtr ctrl);
         private static _GuiScriptNotifyCtrlGetOnChildRemoved _GuiScriptNotifyCtrlGetOnChildRemovedFunc;
         internal static bool GuiScriptNotifyCtrlGetOnChildRemoved(IntPtr ctrl)
         {
            if (_GuiScriptNotifyCtrlGetOnChildRemovedFunc == null)
            {
               _GuiScriptNotifyCtrlGetOnChildRemovedFunc =
                  (_GuiScriptNotifyCtrlGetOnChildRemoved)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlGetOnChildRemoved"), typeof(_GuiScriptNotifyCtrlGetOnChildRemoved));
            }

            return _GuiScriptNotifyCtrlGetOnChildRemovedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScriptNotifyCtrlSetOnChildRemoved(IntPtr ctrl, bool value);
         private static _GuiScriptNotifyCtrlSetOnChildRemoved _GuiScriptNotifyCtrlSetOnChildRemovedFunc;
         internal static void GuiScriptNotifyCtrlSetOnChildRemoved(IntPtr ctrl, bool value)
         {
            if (_GuiScriptNotifyCtrlSetOnChildRemovedFunc == null)
            {
               _GuiScriptNotifyCtrlSetOnChildRemovedFunc =
                  (_GuiScriptNotifyCtrlSetOnChildRemoved)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlSetOnChildRemoved"), typeof(_GuiScriptNotifyCtrlSetOnChildRemoved));
            }

            _GuiScriptNotifyCtrlSetOnChildRemovedFunc(ctrl, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScriptNotifyCtrlGetOnChildResized(IntPtr ctrl);
         private static _GuiScriptNotifyCtrlGetOnChildResized _GuiScriptNotifyCtrlGetOnChildResizedFunc;
         internal static bool GuiScriptNotifyCtrlGetOnChildResized(IntPtr ctrl)
         {
            if (_GuiScriptNotifyCtrlGetOnChildResizedFunc == null)
            {
               _GuiScriptNotifyCtrlGetOnChildResizedFunc =
                  (_GuiScriptNotifyCtrlGetOnChildResized)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlGetOnChildResized"), typeof(_GuiScriptNotifyCtrlGetOnChildResized));
            }

            return _GuiScriptNotifyCtrlGetOnChildResizedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScriptNotifyCtrlSetOnChildResized(IntPtr ctrl, bool value);
         private static _GuiScriptNotifyCtrlSetOnChildResized _GuiScriptNotifyCtrlSetOnChildResizedFunc;
         internal static void GuiScriptNotifyCtrlSetOnChildResized(IntPtr ctrl, bool value)
         {
            if (_GuiScriptNotifyCtrlSetOnChildResizedFunc == null)
            {
               _GuiScriptNotifyCtrlSetOnChildResizedFunc =
                  (_GuiScriptNotifyCtrlSetOnChildResized)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlSetOnChildResized"), typeof(_GuiScriptNotifyCtrlSetOnChildResized));
            }

            _GuiScriptNotifyCtrlSetOnChildResizedFunc(ctrl, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScriptNotifyCtrlGetOnParentResized(IntPtr ctrl);
         private static _GuiScriptNotifyCtrlGetOnParentResized _GuiScriptNotifyCtrlGetOnParentResizedFunc;
         internal static bool GuiScriptNotifyCtrlGetOnParentResized(IntPtr ctrl)
         {
            if (_GuiScriptNotifyCtrlGetOnParentResizedFunc == null)
            {
               _GuiScriptNotifyCtrlGetOnParentResizedFunc =
                  (_GuiScriptNotifyCtrlGetOnParentResized)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlGetOnParentResized"), typeof(_GuiScriptNotifyCtrlGetOnParentResized));
            }

            return _GuiScriptNotifyCtrlGetOnParentResizedFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScriptNotifyCtrlSetOnParentResized(IntPtr ctrl, bool value);
         private static _GuiScriptNotifyCtrlSetOnParentResized _GuiScriptNotifyCtrlSetOnParentResizedFunc;
         internal static void GuiScriptNotifyCtrlSetOnParentResized(IntPtr ctrl, bool value)
         {
            if (_GuiScriptNotifyCtrlSetOnParentResizedFunc == null)
            {
               _GuiScriptNotifyCtrlSetOnParentResizedFunc =
                  (_GuiScriptNotifyCtrlSetOnParentResized)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlSetOnParentResized"), typeof(_GuiScriptNotifyCtrlSetOnParentResized));
            }

            _GuiScriptNotifyCtrlSetOnParentResizedFunc(ctrl, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScriptNotifyCtrlGetOnResize(IntPtr ctrl);
         private static _GuiScriptNotifyCtrlGetOnResize _GuiScriptNotifyCtrlGetOnResizeFunc;
         internal static bool GuiScriptNotifyCtrlGetOnResize(IntPtr ctrl)
         {
            if (_GuiScriptNotifyCtrlGetOnResizeFunc == null)
            {
               _GuiScriptNotifyCtrlGetOnResizeFunc =
                  (_GuiScriptNotifyCtrlGetOnResize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlGetOnResize"), typeof(_GuiScriptNotifyCtrlGetOnResize));
            }

            return _GuiScriptNotifyCtrlGetOnResizeFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScriptNotifyCtrlSetOnResize(IntPtr ctrl, bool value);
         private static _GuiScriptNotifyCtrlSetOnResize _GuiScriptNotifyCtrlSetOnResizeFunc;
         internal static void GuiScriptNotifyCtrlSetOnResize(IntPtr ctrl, bool value)
         {
            if (_GuiScriptNotifyCtrlSetOnResizeFunc == null)
            {
               _GuiScriptNotifyCtrlSetOnResizeFunc =
                  (_GuiScriptNotifyCtrlSetOnResize)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlSetOnResize"), typeof(_GuiScriptNotifyCtrlSetOnResize));
            }

            _GuiScriptNotifyCtrlSetOnResizeFunc(ctrl, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScriptNotifyCtrlGetOnLoseFirstResponder(IntPtr ctrl);
         private static _GuiScriptNotifyCtrlGetOnLoseFirstResponder _GuiScriptNotifyCtrlGetOnLoseFirstResponderFunc;
         internal static bool GuiScriptNotifyCtrlGetOnLoseFirstResponder(IntPtr ctrl)
         {
            if (_GuiScriptNotifyCtrlGetOnLoseFirstResponderFunc == null)
            {
               _GuiScriptNotifyCtrlGetOnLoseFirstResponderFunc =
                  (_GuiScriptNotifyCtrlGetOnLoseFirstResponder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlGetOnLoseFirstResponder"), typeof(_GuiScriptNotifyCtrlGetOnLoseFirstResponder));
            }

            return _GuiScriptNotifyCtrlGetOnLoseFirstResponderFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScriptNotifyCtrlSetOnLoseFirstResponder(IntPtr ctrl, bool value);
         private static _GuiScriptNotifyCtrlSetOnLoseFirstResponder _GuiScriptNotifyCtrlSetOnLoseFirstResponderFunc;
         internal static void GuiScriptNotifyCtrlSetOnLoseFirstResponder(IntPtr ctrl, bool value)
         {
            if (_GuiScriptNotifyCtrlSetOnLoseFirstResponderFunc == null)
            {
               _GuiScriptNotifyCtrlSetOnLoseFirstResponderFunc =
                  (_GuiScriptNotifyCtrlSetOnLoseFirstResponder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlSetOnLoseFirstResponder"), typeof(_GuiScriptNotifyCtrlSetOnLoseFirstResponder));
            }

            _GuiScriptNotifyCtrlSetOnLoseFirstResponderFunc(ctrl, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiScriptNotifyCtrlGetOnGainFirstResponder(IntPtr ctrl);
         private static _GuiScriptNotifyCtrlGetOnGainFirstResponder _GuiScriptNotifyCtrlGetOnGainFirstResponderFunc;
         internal static bool GuiScriptNotifyCtrlGetOnGainFirstResponder(IntPtr ctrl)
         {
            if (_GuiScriptNotifyCtrlGetOnGainFirstResponderFunc == null)
            {
               _GuiScriptNotifyCtrlGetOnGainFirstResponderFunc =
                  (_GuiScriptNotifyCtrlGetOnGainFirstResponder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlGetOnGainFirstResponder"), typeof(_GuiScriptNotifyCtrlGetOnGainFirstResponder));
            }

            return _GuiScriptNotifyCtrlGetOnGainFirstResponderFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiScriptNotifyCtrlSetOnGainFirstResponder(IntPtr ctrl, bool value);
         private static _GuiScriptNotifyCtrlSetOnGainFirstResponder _GuiScriptNotifyCtrlSetOnGainFirstResponderFunc;
         internal static void GuiScriptNotifyCtrlSetOnGainFirstResponder(IntPtr ctrl, bool value)
         {
            if (_GuiScriptNotifyCtrlSetOnGainFirstResponderFunc == null)
            {
               _GuiScriptNotifyCtrlSetOnGainFirstResponderFunc =
                  (_GuiScriptNotifyCtrlSetOnGainFirstResponder)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlSetOnGainFirstResponder"), typeof(_GuiScriptNotifyCtrlSetOnGainFirstResponder));
            }

            _GuiScriptNotifyCtrlSetOnGainFirstResponderFunc(ctrl, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiScriptNotifyCtrlCreateInstance();
         private static _GuiScriptNotifyCtrlCreateInstance _GuiScriptNotifyCtrlCreateInstanceFunc;
         internal static IntPtr GuiScriptNotifyCtrlCreateInstance()
         {
            if (_GuiScriptNotifyCtrlCreateInstanceFunc == null)
            {
               _GuiScriptNotifyCtrlCreateInstanceFunc =
                  (_GuiScriptNotifyCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiScriptNotifyCtrlCreateInstance"), typeof(_GuiScriptNotifyCtrlCreateInstance));
            }

            return _GuiScriptNotifyCtrlCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public bool OnChildAdded
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScriptNotifyCtrlGetOnChildAdded(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScriptNotifyCtrlSetOnChildAdded(ObjectPtr->ObjPtr, value);
         }
      }
      public bool OnChildRemoved
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScriptNotifyCtrlGetOnChildRemoved(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScriptNotifyCtrlSetOnChildRemoved(ObjectPtr->ObjPtr, value);
         }
      }
      public bool OnChildResized
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScriptNotifyCtrlGetOnChildResized(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScriptNotifyCtrlSetOnChildResized(ObjectPtr->ObjPtr, value);
         }
      }
      public bool OnParentResized
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScriptNotifyCtrlGetOnParentResized(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScriptNotifyCtrlSetOnParentResized(ObjectPtr->ObjPtr, value);
         }
      }
      public bool OnResize
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScriptNotifyCtrlGetOnResize(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScriptNotifyCtrlSetOnResize(ObjectPtr->ObjPtr, value);
         }
      }
      public bool OnLoseFirstResponder
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScriptNotifyCtrlGetOnLoseFirstResponder(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScriptNotifyCtrlSetOnLoseFirstResponder(ObjectPtr->ObjPtr, value);
         }
      }
      public bool OnGainFirstResponder
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiScriptNotifyCtrlGetOnGainFirstResponder(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiScriptNotifyCtrlSetOnGainFirstResponder(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}