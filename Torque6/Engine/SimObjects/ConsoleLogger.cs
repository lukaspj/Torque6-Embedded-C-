using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ConsoleLogger : SimObject
   {
      
      public ConsoleLogger()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ConsoleLoggerCreateInstance());
      }

      public ConsoleLogger(uint pId) : base(pId)
      {
      }

      public ConsoleLogger(string pName) : base(pName)
      {
      }

      public ConsoleLogger(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ConsoleLogger(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ConsoleLogger(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ConsoleLoggerGetLevel(IntPtr logger);
         private static _ConsoleLoggerGetLevel _ConsoleLoggerGetLevelFunc;
         internal static int ConsoleLoggerGetLevel(IntPtr logger)
         {
            if (_ConsoleLoggerGetLevelFunc == null)
            {
               _ConsoleLoggerGetLevelFunc =
                  (_ConsoleLoggerGetLevel)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ConsoleLoggerGetLevel"), typeof(_ConsoleLoggerGetLevel));
            }

            return _ConsoleLoggerGetLevelFunc(logger);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ConsoleLoggerSetLevel(IntPtr logger, int value);
         private static _ConsoleLoggerSetLevel _ConsoleLoggerSetLevelFunc;
         internal static void ConsoleLoggerSetLevel(IntPtr logger, int value)
         {
            if (_ConsoleLoggerSetLevelFunc == null)
            {
               _ConsoleLoggerSetLevelFunc =
                  (_ConsoleLoggerSetLevel)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ConsoleLoggerSetLevel"), typeof(_ConsoleLoggerSetLevel));
            }

            _ConsoleLoggerSetLevelFunc(logger, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ConsoleLoggerCreateInstance();
         private static _ConsoleLoggerCreateInstance _ConsoleLoggerCreateInstanceFunc;
         internal static IntPtr ConsoleLoggerCreateInstance()
         {
            if (_ConsoleLoggerCreateInstanceFunc == null)
            {
               _ConsoleLoggerCreateInstanceFunc =
                  (_ConsoleLoggerCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ConsoleLoggerCreateInstance"), typeof(_ConsoleLoggerCreateInstance));
            }

            return _ConsoleLoggerCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ConsoleLoggerAttach(IntPtr logger);
         private static _ConsoleLoggerAttach _ConsoleLoggerAttachFunc;
         internal static bool ConsoleLoggerAttach(IntPtr logger)
         {
            if (_ConsoleLoggerAttachFunc == null)
            {
               _ConsoleLoggerAttachFunc =
                  (_ConsoleLoggerAttach)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ConsoleLoggerAttach"), typeof(_ConsoleLoggerAttach));
            }

            return _ConsoleLoggerAttachFunc(logger);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ConsoleLoggerDetach(IntPtr logger);
         private static _ConsoleLoggerDetach _ConsoleLoggerDetachFunc;
         internal static bool ConsoleLoggerDetach(IntPtr logger)
         {
            if (_ConsoleLoggerDetachFunc == null)
            {
               _ConsoleLoggerDetachFunc =
                  (_ConsoleLoggerDetach)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ConsoleLoggerDetach"), typeof(_ConsoleLoggerDetach));
            }

            return _ConsoleLoggerDetachFunc(logger);
         }
      }
      
      #endregion

      #region Properties

      public int Level
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ConsoleLoggerGetLevel(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ConsoleLoggerSetLevel(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool Attach()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ConsoleLoggerAttach(ObjectPtr->ObjPtr);
      }

      public bool Detach()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ConsoleLoggerDetach(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}