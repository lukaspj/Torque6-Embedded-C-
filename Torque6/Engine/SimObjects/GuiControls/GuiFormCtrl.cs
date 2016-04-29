using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class GuiFormCtrl : GuiControl
   {
      
      public GuiFormCtrl()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.GuiFormCtrlCreateInstance());
      }

      public GuiFormCtrl(uint pId) : base(pId)
      {
      }

      public GuiFormCtrl(string pName) : base(pName)
      {
      }

      public GuiFormCtrl(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public GuiFormCtrl(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public GuiFormCtrl(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFormCtrlGetCaption(IntPtr ctrl);
         private static _GuiFormCtrlGetCaption _GuiFormCtrlGetCaptionFunc;
         internal static IntPtr GuiFormCtrlGetCaption(IntPtr ctrl)
         {
            if (_GuiFormCtrlGetCaptionFunc == null)
            {
               _GuiFormCtrlGetCaptionFunc =
                  (_GuiFormCtrlGetCaption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlGetCaption"), typeof(_GuiFormCtrlGetCaption));
            }

            return _GuiFormCtrlGetCaptionFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFormCtrlSetCaption(IntPtr ctrl, string caption);
         private static _GuiFormCtrlSetCaption _GuiFormCtrlSetCaptionFunc;
         internal static void GuiFormCtrlSetCaption(IntPtr ctrl, string caption)
         {
            if (_GuiFormCtrlSetCaptionFunc == null)
            {
               _GuiFormCtrlSetCaptionFunc =
                  (_GuiFormCtrlSetCaption)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlSetCaption"), typeof(_GuiFormCtrlSetCaption));
            }

            _GuiFormCtrlSetCaptionFunc(ctrl, caption);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFormCtrlGetContentLibrary(IntPtr ctrl);
         private static _GuiFormCtrlGetContentLibrary _GuiFormCtrlGetContentLibraryFunc;
         internal static IntPtr GuiFormCtrlGetContentLibrary(IntPtr ctrl)
         {
            if (_GuiFormCtrlGetContentLibraryFunc == null)
            {
               _GuiFormCtrlGetContentLibraryFunc =
                  (_GuiFormCtrlGetContentLibrary)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlGetContentLibrary"), typeof(_GuiFormCtrlGetContentLibrary));
            }

            return _GuiFormCtrlGetContentLibraryFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFormCtrlSetContentLibrary(IntPtr ctrl, string contentLibrary);
         private static _GuiFormCtrlSetContentLibrary _GuiFormCtrlSetContentLibraryFunc;
         internal static void GuiFormCtrlSetContentLibrary(IntPtr ctrl, string contentLibrary)
         {
            if (_GuiFormCtrlSetContentLibraryFunc == null)
            {
               _GuiFormCtrlSetContentLibraryFunc =
                  (_GuiFormCtrlSetContentLibrary)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlSetContentLibrary"), typeof(_GuiFormCtrlSetContentLibrary));
            }

            _GuiFormCtrlSetContentLibraryFunc(ctrl, contentLibrary);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFormCtrlGetContent(IntPtr ctrl);
         private static _GuiFormCtrlGetContent _GuiFormCtrlGetContentFunc;
         internal static IntPtr GuiFormCtrlGetContent(IntPtr ctrl)
         {
            if (_GuiFormCtrlGetContentFunc == null)
            {
               _GuiFormCtrlGetContentFunc =
                  (_GuiFormCtrlGetContent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlGetContent"), typeof(_GuiFormCtrlGetContent));
            }

            return _GuiFormCtrlGetContentFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFormCtrlSetContent(IntPtr ctrl, string content);
         private static _GuiFormCtrlSetContent _GuiFormCtrlSetContentFunc;
         internal static void GuiFormCtrlSetContent(IntPtr ctrl, string content)
         {
            if (_GuiFormCtrlSetContentFunc == null)
            {
               _GuiFormCtrlSetContentFunc =
                  (_GuiFormCtrlSetContent)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlSetContent"), typeof(_GuiFormCtrlSetContent));
            }

            _GuiFormCtrlSetContentFunc(ctrl, content);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiFormCtrlGetMovable(IntPtr ctrl);
         private static _GuiFormCtrlGetMovable _GuiFormCtrlGetMovableFunc;
         internal static bool GuiFormCtrlGetMovable(IntPtr ctrl)
         {
            if (_GuiFormCtrlGetMovableFunc == null)
            {
               _GuiFormCtrlGetMovableFunc =
                  (_GuiFormCtrlGetMovable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlGetMovable"), typeof(_GuiFormCtrlGetMovable));
            }

            return _GuiFormCtrlGetMovableFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFormCtrlSetMovable(IntPtr ctrl, bool movable);
         private static _GuiFormCtrlSetMovable _GuiFormCtrlSetMovableFunc;
         internal static void GuiFormCtrlSetMovable(IntPtr ctrl, bool movable)
         {
            if (_GuiFormCtrlSetMovableFunc == null)
            {
               _GuiFormCtrlSetMovableFunc =
                  (_GuiFormCtrlSetMovable)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlSetMovable"), typeof(_GuiFormCtrlSetMovable));
            }

            _GuiFormCtrlSetMovableFunc(ctrl, movable);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _GuiFormCtrlGetHasMenu(IntPtr ctrl);
         private static _GuiFormCtrlGetHasMenu _GuiFormCtrlGetHasMenuFunc;
         internal static bool GuiFormCtrlGetHasMenu(IntPtr ctrl)
         {
            if (_GuiFormCtrlGetHasMenuFunc == null)
            {
               _GuiFormCtrlGetHasMenuFunc =
                  (_GuiFormCtrlGetHasMenu)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlGetHasMenu"), typeof(_GuiFormCtrlGetHasMenu));
            }

            return _GuiFormCtrlGetHasMenuFunc(ctrl);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _GuiFormCtrlSetHasMenu(IntPtr ctrl, bool hasMenu);
         private static _GuiFormCtrlSetHasMenu _GuiFormCtrlSetHasMenuFunc;
         internal static void GuiFormCtrlSetHasMenu(IntPtr ctrl, bool hasMenu)
         {
            if (_GuiFormCtrlSetHasMenuFunc == null)
            {
               _GuiFormCtrlSetHasMenuFunc =
                  (_GuiFormCtrlSetHasMenu)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlSetHasMenu"), typeof(_GuiFormCtrlSetHasMenu));
            }

            _GuiFormCtrlSetHasMenuFunc(ctrl, hasMenu);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFormCtrlCreateInstance();
         private static _GuiFormCtrlCreateInstance _GuiFormCtrlCreateInstanceFunc;
         internal static IntPtr GuiFormCtrlCreateInstance()
         {
            if (_GuiFormCtrlCreateInstanceFunc == null)
            {
               _GuiFormCtrlCreateInstanceFunc =
                  (_GuiFormCtrlCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlCreateInstance"), typeof(_GuiFormCtrlCreateInstance));
            }

            return _GuiFormCtrlCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _GuiFormCtrlGetMenuID(IntPtr ctrl);
         private static _GuiFormCtrlGetMenuID _GuiFormCtrlGetMenuIDFunc;
         internal static int GuiFormCtrlGetMenuID(IntPtr ctrl)
         {
            if (_GuiFormCtrlGetMenuIDFunc == null)
            {
               _GuiFormCtrlGetMenuIDFunc =
                  (_GuiFormCtrlGetMenuID)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "GuiFormCtrlGetMenuID"), typeof(_GuiFormCtrlGetMenuID));
            }

            return _GuiFormCtrlGetMenuIDFunc(ctrl);
         }
      }
      
      #endregion

      #region Properties

      public string Caption
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiFormCtrlGetCaption(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFormCtrlSetCaption(ObjectPtr->ObjPtr, value);
         }
      }
      public string ContentLibrary
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiFormCtrlGetContentLibrary(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFormCtrlSetContentLibrary(ObjectPtr->ObjPtr, value);
         }
      }
      public string Content
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.GuiFormCtrlGetContent(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFormCtrlSetContent(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Movable
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiFormCtrlGetMovable(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFormCtrlSetMovable(ObjectPtr->ObjPtr, value);
         }
      }
      public bool HasMenu
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.GuiFormCtrlGetHasMenu(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.GuiFormCtrlSetHasMenu(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public int GetMenuID()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.GuiFormCtrlGetMenuID(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}