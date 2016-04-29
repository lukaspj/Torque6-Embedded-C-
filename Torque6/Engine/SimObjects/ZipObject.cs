using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ZipObject : SimObject
   {
      
      public ZipObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ZipObjectCreateInstance());
      }

      public ZipObject(uint pId) : base(pId)
      {
      }

      public ZipObject(string pName) : base(pName)
      {
      }

      public ZipObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ZipObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ZipObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ZipObjectCreateInstance();
         private static _ZipObjectCreateInstance _ZipObjectCreateInstanceFunc;
         internal static IntPtr ZipObjectCreateInstance()
         {
            if (_ZipObjectCreateInstanceFunc == null)
            {
               _ZipObjectCreateInstanceFunc =
                  (_ZipObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectCreateInstance"), typeof(_ZipObjectCreateInstance));
            }

            return _ZipObjectCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ZipObjectOpenArchive(IntPtr zipObj, string fileName, int mode);
         private static _ZipObjectOpenArchive _ZipObjectOpenArchiveFunc;
         internal static bool ZipObjectOpenArchive(IntPtr zipObj, string fileName, int mode)
         {
            if (_ZipObjectOpenArchiveFunc == null)
            {
               _ZipObjectOpenArchiveFunc =
                  (_ZipObjectOpenArchive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectOpenArchive"), typeof(_ZipObjectOpenArchive));
            }

            return _ZipObjectOpenArchiveFunc(zipObj, fileName, mode);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ZipObjectCloseArchive(IntPtr zipObj);
         private static _ZipObjectCloseArchive _ZipObjectCloseArchiveFunc;
         internal static void ZipObjectCloseArchive(IntPtr zipObj)
         {
            if (_ZipObjectCloseArchiveFunc == null)
            {
               _ZipObjectCloseArchiveFunc =
                  (_ZipObjectCloseArchive)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectCloseArchive"), typeof(_ZipObjectCloseArchive));
            }

            _ZipObjectCloseArchiveFunc(zipObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ZipObjectOpenFileForRead(IntPtr zipObj, string fileName);
         private static _ZipObjectOpenFileForRead _ZipObjectOpenFileForReadFunc;
         internal static IntPtr ZipObjectOpenFileForRead(IntPtr zipObj, string fileName)
         {
            if (_ZipObjectOpenFileForReadFunc == null)
            {
               _ZipObjectOpenFileForReadFunc =
                  (_ZipObjectOpenFileForRead)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectOpenFileForRead"), typeof(_ZipObjectOpenFileForRead));
            }

            return _ZipObjectOpenFileForReadFunc(zipObj, fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ZipObjectOpenFileForWrite(IntPtr zipObj, string fileName);
         private static _ZipObjectOpenFileForWrite _ZipObjectOpenFileForWriteFunc;
         internal static IntPtr ZipObjectOpenFileForWrite(IntPtr zipObj, string fileName)
         {
            if (_ZipObjectOpenFileForWriteFunc == null)
            {
               _ZipObjectOpenFileForWriteFunc =
                  (_ZipObjectOpenFileForWrite)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectOpenFileForWrite"), typeof(_ZipObjectOpenFileForWrite));
            }

            return _ZipObjectOpenFileForWriteFunc(zipObj, fileName);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ZipObjectCloseFile(IntPtr zipObj, IntPtr stream);
         private static _ZipObjectCloseFile _ZipObjectCloseFileFunc;
         internal static void ZipObjectCloseFile(IntPtr zipObj, IntPtr stream)
         {
            if (_ZipObjectCloseFileFunc == null)
            {
               _ZipObjectCloseFileFunc =
                  (_ZipObjectCloseFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectCloseFile"), typeof(_ZipObjectCloseFile));
            }

            _ZipObjectCloseFileFunc(zipObj, stream);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ZipObjectAddFile(IntPtr zipObj, string fileName, string pathInZip, bool replace);
         private static _ZipObjectAddFile _ZipObjectAddFileFunc;
         internal static bool ZipObjectAddFile(IntPtr zipObj, string fileName, string pathInZip, bool replace)
         {
            if (_ZipObjectAddFileFunc == null)
            {
               _ZipObjectAddFileFunc =
                  (_ZipObjectAddFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectAddFile"), typeof(_ZipObjectAddFile));
            }

            return _ZipObjectAddFileFunc(zipObj, fileName, pathInZip, replace);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ZipObjectExtractFile(IntPtr zipObj, string fileName, string pathInZip);
         private static _ZipObjectExtractFile _ZipObjectExtractFileFunc;
         internal static bool ZipObjectExtractFile(IntPtr zipObj, string fileName, string pathInZip)
         {
            if (_ZipObjectExtractFileFunc == null)
            {
               _ZipObjectExtractFileFunc =
                  (_ZipObjectExtractFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectExtractFile"), typeof(_ZipObjectExtractFile));
            }

            return _ZipObjectExtractFileFunc(zipObj, fileName, pathInZip);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ZipObjectDeleteFile(IntPtr zipObj, string pathInZip);
         private static _ZipObjectDeleteFile _ZipObjectDeleteFileFunc;
         internal static bool ZipObjectDeleteFile(IntPtr zipObj, string pathInZip)
         {
            if (_ZipObjectDeleteFileFunc == null)
            {
               _ZipObjectDeleteFileFunc =
                  (_ZipObjectDeleteFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectDeleteFile"), typeof(_ZipObjectDeleteFile));
            }

            return _ZipObjectDeleteFileFunc(zipObj, pathInZip);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _ZipObjectGetFileEntryCount(IntPtr zipObj);
         private static _ZipObjectGetFileEntryCount _ZipObjectGetFileEntryCountFunc;
         internal static int ZipObjectGetFileEntryCount(IntPtr zipObj)
         {
            if (_ZipObjectGetFileEntryCountFunc == null)
            {
               _ZipObjectGetFileEntryCountFunc =
                  (_ZipObjectGetFileEntryCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectGetFileEntryCount"), typeof(_ZipObjectGetFileEntryCount));
            }

            return _ZipObjectGetFileEntryCountFunc(zipObj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ZipObjectGetFileEntry(IntPtr zipObj, int index);
         private static _ZipObjectGetFileEntry _ZipObjectGetFileEntryFunc;
         internal static IntPtr ZipObjectGetFileEntry(IntPtr zipObj, int index)
         {
            if (_ZipObjectGetFileEntryFunc == null)
            {
               _ZipObjectGetFileEntryFunc =
                  (_ZipObjectGetFileEntry)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ZipObjectGetFileEntry"), typeof(_ZipObjectGetFileEntry));
            }

            return _ZipObjectGetFileEntryFunc(zipObj, index);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public bool OpenArchive(string fileName, int mode = 0)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ZipObjectOpenArchive(ObjectPtr->ObjPtr, fileName, mode);
      }

      public void CloseArchive()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ZipObjectCloseArchive(ObjectPtr->ObjPtr);
      }

      public StreamObject OpenFileForRead(string fileName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new StreamObject(InternalUnsafeMethods.ZipObjectOpenFileForRead(ObjectPtr->ObjPtr, fileName));
      }

      public StreamObject OpenFileForWrite(string fileName)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new StreamObject(InternalUnsafeMethods.ZipObjectOpenFileForWrite(ObjectPtr->ObjPtr, fileName));
      }

      public void CloseFile(StreamObject stream)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ZipObjectCloseFile(ObjectPtr->ObjPtr, stream.ObjectPtr->ObjPtr);
      }

      public bool AddFile(string fileName, string pathInZip, bool replace = true)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ZipObjectAddFile(ObjectPtr->ObjPtr, fileName, pathInZip, replace);
      }

      public bool ExtractFile(string fileName, string pathInZip)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ZipObjectExtractFile(ObjectPtr->ObjPtr, fileName, pathInZip);
      }

      public bool DeleteFile(string pathInZip)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ZipObjectDeleteFile(ObjectPtr->ObjPtr, pathInZip);
      }

      public int GetFileEntryCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ZipObjectGetFileEntryCount(ObjectPtr->ObjPtr);
      }

      public string GetFileEntry(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ZipObjectGetFileEntry(ObjectPtr->ObjPtr, index));
      }
      
      #endregion

      
   }
}