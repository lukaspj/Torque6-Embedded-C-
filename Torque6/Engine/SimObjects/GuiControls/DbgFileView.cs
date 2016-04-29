using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.GuiControls
{
   public unsafe class DbgFileView : GuiArrayCtrl
   {
      
      public DbgFileView()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.DbgFileViewCreateInstance());
      }

      public DbgFileView(uint pId) : base(pId)
      {
      }

      public DbgFileView(string pName) : base(pName)
      {
      }

      public DbgFileView(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public DbgFileView(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public DbgFileView(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DbgFileViewCreateInstance();
         private static _DbgFileViewCreateInstance _DbgFileViewCreateInstanceFunc;
         internal static IntPtr DbgFileViewCreateInstance()
         {
            if (_DbgFileViewCreateInstanceFunc == null)
            {
               _DbgFileViewCreateInstanceFunc =
                  (_DbgFileViewCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DbgFileViewCreateInstance"), typeof(_DbgFileViewCreateInstance));
            }

            return _DbgFileViewCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DbgFileViewSetCurrentLine(IntPtr view, int line, bool selected);
         private static _DbgFileViewSetCurrentLine _DbgFileViewSetCurrentLineFunc;
         internal static void DbgFileViewSetCurrentLine(IntPtr view, int line, bool selected)
         {
            if (_DbgFileViewSetCurrentLineFunc == null)
            {
               _DbgFileViewSetCurrentLineFunc =
                  (_DbgFileViewSetCurrentLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DbgFileViewSetCurrentLine"), typeof(_DbgFileViewSetCurrentLine));
            }

            _DbgFileViewSetCurrentLineFunc(view, line, selected);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DbgFileViewGetCurrentLine(IntPtr view, int line, bool selected);
         private static _DbgFileViewGetCurrentLine _DbgFileViewGetCurrentLineFunc;
         internal static IntPtr DbgFileViewGetCurrentLine(IntPtr view, int line, bool selected)
         {
            if (_DbgFileViewGetCurrentLineFunc == null)
            {
               _DbgFileViewGetCurrentLineFunc =
                  (_DbgFileViewGetCurrentLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DbgFileViewGetCurrentLine"), typeof(_DbgFileViewGetCurrentLine));
            }

            return _DbgFileViewGetCurrentLineFunc(view, line, selected);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _DbgFileViewOpen(IntPtr view, string fileName);
         private static _DbgFileViewOpen _DbgFileViewOpenFunc;
         internal static bool DbgFileViewOpen(IntPtr view, string fileName)
         {
            if (_DbgFileViewOpenFunc == null)
            {
               _DbgFileViewOpenFunc =
                  (_DbgFileViewOpen)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DbgFileViewOpen"), typeof(_DbgFileViewOpen));
            }

            return _DbgFileViewOpenFunc(view, fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DbgFileViewClearBreakPositions(IntPtr view);
         private static _DbgFileViewClearBreakPositions _DbgFileViewClearBreakPositionsFunc;
         internal static void DbgFileViewClearBreakPositions(IntPtr view)
         {
            if (_DbgFileViewClearBreakPositionsFunc == null)
            {
               _DbgFileViewClearBreakPositionsFunc =
                  (_DbgFileViewClearBreakPositions)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DbgFileViewClearBreakPositions"), typeof(_DbgFileViewClearBreakPositions));
            }

            _DbgFileViewClearBreakPositionsFunc(view);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DbgFileViewSetBreakPosition(IntPtr view, int line);
         private static _DbgFileViewSetBreakPosition _DbgFileViewSetBreakPositionFunc;
         internal static void DbgFileViewSetBreakPosition(IntPtr view, int line)
         {
            if (_DbgFileViewSetBreakPositionFunc == null)
            {
               _DbgFileViewSetBreakPositionFunc =
                  (_DbgFileViewSetBreakPosition)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DbgFileViewSetBreakPosition"), typeof(_DbgFileViewSetBreakPosition));
            }

            _DbgFileViewSetBreakPositionFunc(view, line);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DbgFileViewSetBreak(IntPtr view, int line);
         private static _DbgFileViewSetBreak _DbgFileViewSetBreakFunc;
         internal static void DbgFileViewSetBreak(IntPtr view, int line)
         {
            if (_DbgFileViewSetBreakFunc == null)
            {
               _DbgFileViewSetBreakFunc =
                  (_DbgFileViewSetBreak)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DbgFileViewSetBreak"), typeof(_DbgFileViewSetBreak));
            }

            _DbgFileViewSetBreakFunc(view, line);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DbgFileViewRemoveBreak(IntPtr view, int line);
         private static _DbgFileViewRemoveBreak _DbgFileViewRemoveBreakFunc;
         internal static void DbgFileViewRemoveBreak(IntPtr view, int line)
         {
            if (_DbgFileViewRemoveBreakFunc == null)
            {
               _DbgFileViewRemoveBreakFunc =
                  (_DbgFileViewRemoveBreak)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DbgFileViewRemoveBreak"), typeof(_DbgFileViewRemoveBreak));
            }

            _DbgFileViewRemoveBreakFunc(view, line);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _DbgFileViewFindString(IntPtr view, string findThis);
         private static _DbgFileViewFindString _DbgFileViewFindStringFunc;
         internal static bool DbgFileViewFindString(IntPtr view, string findThis)
         {
            if (_DbgFileViewFindStringFunc == null)
            {
               _DbgFileViewFindStringFunc =
                  (_DbgFileViewFindString)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "DbgFileViewFindString"), typeof(_DbgFileViewFindString));
            }

            return _DbgFileViewFindStringFunc(view, findThis);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void SetCurrentLine(int line, bool selected)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.DbgFileViewSetCurrentLine(ObjectPtr->ObjPtr, line, selected);
      }

      public string GetCurrentLine(int line, bool selected)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.DbgFileViewGetCurrentLine(ObjectPtr->ObjPtr, line, selected));
      }

      public bool Open(string fileName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.DbgFileViewOpen(ObjectPtr->ObjPtr, fileName);
      }

      public void ClearBreakPositions()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.DbgFileViewClearBreakPositions(ObjectPtr->ObjPtr);
      }

      public void SetBreakPosition(int line)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.DbgFileViewSetBreakPosition(ObjectPtr->ObjPtr, line);
      }

      public void SetBreak(int line)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.DbgFileViewSetBreak(ObjectPtr->ObjPtr, line);
      }

      public void RemoveBreak(int line)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.DbgFileViewRemoveBreak(ObjectPtr->ObjPtr, line);
      }

      public bool FindString(string findThis)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.DbgFileViewFindString(ObjectPtr->ObjPtr, findThis);
      }
      
      #endregion

      
   }
}