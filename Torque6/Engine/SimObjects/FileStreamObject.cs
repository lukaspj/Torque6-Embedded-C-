using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class FileStreamObject : StreamObject
   {
      
      public FileStreamObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.FileStreamObjectCreateInstance());
      }

      public FileStreamObject(uint pId) : base(pId)
      {
      }

      public FileStreamObject(string pName) : base(pName)
      {
      }

      public FileStreamObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public FileStreamObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public FileStreamObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileStreamObjectCreateInstance();
         private static _FileStreamObjectCreateInstance _FileStreamObjectCreateInstanceFunc;
         internal static IntPtr FileStreamObjectCreateInstance()
         {
            if (_FileStreamObjectCreateInstanceFunc == null)
            {
               _FileStreamObjectCreateInstanceFunc =
                  (_FileStreamObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileStreamObjectCreateInstance"), typeof(_FileStreamObjectCreateInstance));
            }

            return _FileStreamObjectCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _FileStreamObjectOpen(IntPtr fileStream, string fileName, int mode);
         private static _FileStreamObjectOpen _FileStreamObjectOpenFunc;
         internal static bool FileStreamObjectOpen(IntPtr fileStream, string fileName, int mode)
         {
            if (_FileStreamObjectOpenFunc == null)
            {
               _FileStreamObjectOpenFunc =
                  (_FileStreamObjectOpen)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileStreamObjectOpen"), typeof(_FileStreamObjectOpen));
            }

            return _FileStreamObjectOpenFunc(fileStream, fileName, mode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileStreamObjectClose(IntPtr fileStream);
         private static _FileStreamObjectClose _FileStreamObjectCloseFunc;
         internal static void FileStreamObjectClose(IntPtr fileStream)
         {
            if (_FileStreamObjectCloseFunc == null)
            {
               _FileStreamObjectCloseFunc =
                  (_FileStreamObjectClose)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileStreamObjectClose"), typeof(_FileStreamObjectClose));
            }

            _FileStreamObjectCloseFunc(fileStream);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public bool Open(string fileName, int mode)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.FileStreamObjectOpen(ObjectPtr->ObjPtr, fileName, mode);
      }

      public void Close()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.FileStreamObjectClose(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}