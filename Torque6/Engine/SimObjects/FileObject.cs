using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class FileObject : SimObject
   {
      
      public FileObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.FileObjectCreateInstance());
      }

      public FileObject(uint pId) : base(pId)
      {
      }

      public FileObject(string pName) : base(pName)
      {
      }

      public FileObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public FileObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public FileObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileObjectCreateInstance();
         private static _FileObjectCreateInstance _FileObjectCreateInstanceFunc;
         internal static IntPtr FileObjectCreateInstance()
         {
            if (_FileObjectCreateInstanceFunc == null)
            {
               _FileObjectCreateInstanceFunc =
                  (_FileObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectCreateInstance"), typeof(_FileObjectCreateInstance));
            }

            return _FileObjectCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _FileObjectOpenForRead(IntPtr fileObj, string filename);
         private static _FileObjectOpenForRead _FileObjectOpenForReadFunc;
         internal static bool FileObjectOpenForRead(IntPtr fileObj, string filename)
         {
            if (_FileObjectOpenForReadFunc == null)
            {
               _FileObjectOpenForReadFunc =
                  (_FileObjectOpenForRead)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectOpenForRead"), typeof(_FileObjectOpenForRead));
            }

            return _FileObjectOpenForReadFunc(fileObj, filename);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _FileObjectOpenForWrite(IntPtr fileObj, string filename);
         private static _FileObjectOpenForWrite _FileObjectOpenForWriteFunc;
         internal static bool FileObjectOpenForWrite(IntPtr fileObj, string filename)
         {
            if (_FileObjectOpenForWriteFunc == null)
            {
               _FileObjectOpenForWriteFunc =
                  (_FileObjectOpenForWrite)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectOpenForWrite"), typeof(_FileObjectOpenForWrite));
            }

            return _FileObjectOpenForWriteFunc(fileObj, filename);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _FileObjectOpenForAppend(IntPtr fileObj, string filename);
         private static _FileObjectOpenForAppend _FileObjectOpenForAppendFunc;
         internal static bool FileObjectOpenForAppend(IntPtr fileObj, string filename)
         {
            if (_FileObjectOpenForAppendFunc == null)
            {
               _FileObjectOpenForAppendFunc =
                  (_FileObjectOpenForAppend)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectOpenForAppend"), typeof(_FileObjectOpenForAppend));
            }

            return _FileObjectOpenForAppendFunc(fileObj, filename);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _FileObjectIsEOF(IntPtr fileObj);
         private static _FileObjectIsEOF _FileObjectIsEOFFunc;
         internal static bool FileObjectIsEOF(IntPtr fileObj)
         {
            if (_FileObjectIsEOFFunc == null)
            {
               _FileObjectIsEOFFunc =
                  (_FileObjectIsEOF)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectIsEOF"), typeof(_FileObjectIsEOF));
            }

            return _FileObjectIsEOFFunc(fileObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileObjectReadLine(IntPtr fileObj);
         private static _FileObjectReadLine _FileObjectReadLineFunc;
         internal static IntPtr FileObjectReadLine(IntPtr fileObj)
         {
            if (_FileObjectReadLineFunc == null)
            {
               _FileObjectReadLineFunc =
                  (_FileObjectReadLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectReadLine"), typeof(_FileObjectReadLine));
            }

            return _FileObjectReadLineFunc(fileObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileObjectPeekLine(IntPtr fileObj);
         private static _FileObjectPeekLine _FileObjectPeekLineFunc;
         internal static IntPtr FileObjectPeekLine(IntPtr fileObj)
         {
            if (_FileObjectPeekLineFunc == null)
            {
               _FileObjectPeekLineFunc =
                  (_FileObjectPeekLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectPeekLine"), typeof(_FileObjectPeekLine));
            }

            return _FileObjectPeekLineFunc(fileObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileObjectWriteLine(IntPtr fileObj, string text);
         private static _FileObjectWriteLine _FileObjectWriteLineFunc;
         internal static void FileObjectWriteLine(IntPtr fileObj, string text)
         {
            if (_FileObjectWriteLineFunc == null)
            {
               _FileObjectWriteLineFunc =
                  (_FileObjectWriteLine)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectWriteLine"), typeof(_FileObjectWriteLine));
            }

            _FileObjectWriteLineFunc(fileObj, text);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileObjectClose(IntPtr fileObj);
         private static _FileObjectClose _FileObjectCloseFunc;
         internal static void FileObjectClose(IntPtr fileObj)
         {
            if (_FileObjectCloseFunc == null)
            {
               _FileObjectCloseFunc =
                  (_FileObjectClose)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectClose"), typeof(_FileObjectClose));
            }

            _FileObjectCloseFunc(fileObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileObjectWriteObject(IntPtr fileObj, IntPtr simObj, string text);
         private static _FileObjectWriteObject _FileObjectWriteObjectFunc;
         internal static void FileObjectWriteObject(IntPtr fileObj, IntPtr simObj, string text)
         {
            if (_FileObjectWriteObjectFunc == null)
            {
               _FileObjectWriteObjectFunc =
                  (_FileObjectWriteObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileObjectWriteObject"), typeof(_FileObjectWriteObject));
            }

            _FileObjectWriteObjectFunc(fileObj, simObj, text);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public bool OpenForRead(string filename)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.FileObjectOpenForRead(ObjectPtr->ObjPtr, filename);
      }

      public bool OpenForWrite(string filename)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.FileObjectOpenForWrite(ObjectPtr->ObjPtr, filename);
      }

      public bool OpenForAppend(string filename)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.FileObjectOpenForAppend(ObjectPtr->ObjPtr, filename);
      }

      public bool IsEOF()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.FileObjectIsEOF(ObjectPtr->ObjPtr);
      }

      public string ReadLine()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.FileObjectReadLine(ObjectPtr->ObjPtr));
      }

      public string PeekLine()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.FileObjectPeekLine(ObjectPtr->ObjPtr));
      }

      public void WriteLine(string text)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.FileObjectWriteLine(ObjectPtr->ObjPtr, text);
      }

      public void Close()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.FileObjectClose(ObjectPtr->ObjPtr);
      }

      public void WriteObject(SimObject simObj, string text = null)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.FileObjectWriteObject(ObjectPtr->ObjPtr, simObj.ObjectPtr->ObjPtr, text);
      }
      
      #endregion

      
   }
}