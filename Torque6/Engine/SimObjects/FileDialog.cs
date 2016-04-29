using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class FileDialog : SimObject
   {
      
      public FileDialog()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.FileDialogCreateInstance());
      }

      public FileDialog(uint pId) : base(pId)
      {
      }

      public FileDialog(string pName) : base(pName)
      {
      }

      public FileDialog(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public FileDialog(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public FileDialog(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileDialogGetDefaultPath(IntPtr fileDialog);
         private static _FileDialogGetDefaultPath _FileDialogGetDefaultPathFunc;
         internal static IntPtr FileDialogGetDefaultPath(IntPtr fileDialog)
         {
            if (_FileDialogGetDefaultPathFunc == null)
            {
               _FileDialogGetDefaultPathFunc =
                  (_FileDialogGetDefaultPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogGetDefaultPath"), typeof(_FileDialogGetDefaultPath));
            }

            return _FileDialogGetDefaultPathFunc(fileDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileDialogSetDefaultPath(IntPtr fileDialog, string value);
         private static _FileDialogSetDefaultPath _FileDialogSetDefaultPathFunc;
         internal static void FileDialogSetDefaultPath(IntPtr fileDialog, string value)
         {
            if (_FileDialogSetDefaultPathFunc == null)
            {
               _FileDialogSetDefaultPathFunc =
                  (_FileDialogSetDefaultPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogSetDefaultPath"), typeof(_FileDialogSetDefaultPath));
            }

            _FileDialogSetDefaultPathFunc(fileDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileDialogGetDefaultFile(IntPtr fileDialog);
         private static _FileDialogGetDefaultFile _FileDialogGetDefaultFileFunc;
         internal static IntPtr FileDialogGetDefaultFile(IntPtr fileDialog)
         {
            if (_FileDialogGetDefaultFileFunc == null)
            {
               _FileDialogGetDefaultFileFunc =
                  (_FileDialogGetDefaultFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogGetDefaultFile"), typeof(_FileDialogGetDefaultFile));
            }

            return _FileDialogGetDefaultFileFunc(fileDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileDialogSetDefaultFile(IntPtr fileDialog, string value);
         private static _FileDialogSetDefaultFile _FileDialogSetDefaultFileFunc;
         internal static void FileDialogSetDefaultFile(IntPtr fileDialog, string value)
         {
            if (_FileDialogSetDefaultFileFunc == null)
            {
               _FileDialogSetDefaultFileFunc =
                  (_FileDialogSetDefaultFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogSetDefaultFile"), typeof(_FileDialogSetDefaultFile));
            }

            _FileDialogSetDefaultFileFunc(fileDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileDialogGetFileName(IntPtr fileDialog);
         private static _FileDialogGetFileName _FileDialogGetFileNameFunc;
         internal static IntPtr FileDialogGetFileName(IntPtr fileDialog)
         {
            if (_FileDialogGetFileNameFunc == null)
            {
               _FileDialogGetFileNameFunc =
                  (_FileDialogGetFileName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogGetFileName"), typeof(_FileDialogGetFileName));
            }

            return _FileDialogGetFileNameFunc(fileDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileDialogSetFileName(IntPtr fileDialog, string value);
         private static _FileDialogSetFileName _FileDialogSetFileNameFunc;
         internal static void FileDialogSetFileName(IntPtr fileDialog, string value)
         {
            if (_FileDialogSetFileNameFunc == null)
            {
               _FileDialogSetFileNameFunc =
                  (_FileDialogSetFileName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogSetFileName"), typeof(_FileDialogSetFileName));
            }

            _FileDialogSetFileNameFunc(fileDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileDialogGetFilters(IntPtr fileDialog);
         private static _FileDialogGetFilters _FileDialogGetFiltersFunc;
         internal static IntPtr FileDialogGetFilters(IntPtr fileDialog)
         {
            if (_FileDialogGetFiltersFunc == null)
            {
               _FileDialogGetFiltersFunc =
                  (_FileDialogGetFilters)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogGetFilters"), typeof(_FileDialogGetFilters));
            }

            return _FileDialogGetFiltersFunc(fileDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileDialogSetFilters(IntPtr fileDialog, string value);
         private static _FileDialogSetFilters _FileDialogSetFiltersFunc;
         internal static void FileDialogSetFilters(IntPtr fileDialog, string value)
         {
            if (_FileDialogSetFiltersFunc == null)
            {
               _FileDialogSetFiltersFunc =
                  (_FileDialogSetFilters)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogSetFilters"), typeof(_FileDialogSetFilters));
            }

            _FileDialogSetFiltersFunc(fileDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileDialogGetTitle(IntPtr fileDialog);
         private static _FileDialogGetTitle _FileDialogGetTitleFunc;
         internal static IntPtr FileDialogGetTitle(IntPtr fileDialog)
         {
            if (_FileDialogGetTitleFunc == null)
            {
               _FileDialogGetTitleFunc =
                  (_FileDialogGetTitle)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogGetTitle"), typeof(_FileDialogGetTitle));
            }

            return _FileDialogGetTitleFunc(fileDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileDialogSetTitle(IntPtr fileDialog, string value);
         private static _FileDialogSetTitle _FileDialogSetTitleFunc;
         internal static void FileDialogSetTitle(IntPtr fileDialog, string value)
         {
            if (_FileDialogSetTitleFunc == null)
            {
               _FileDialogSetTitleFunc =
                  (_FileDialogSetTitle)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogSetTitle"), typeof(_FileDialogSetTitle));
            }

            _FileDialogSetTitleFunc(fileDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _FileDialogGetChangePath(IntPtr fileDialog);
         private static _FileDialogGetChangePath _FileDialogGetChangePathFunc;
         internal static bool FileDialogGetChangePath(IntPtr fileDialog)
         {
            if (_FileDialogGetChangePathFunc == null)
            {
               _FileDialogGetChangePathFunc =
                  (_FileDialogGetChangePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogGetChangePath"), typeof(_FileDialogGetChangePath));
            }

            return _FileDialogGetChangePathFunc(fileDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _FileDialogSetChangePath(IntPtr fileDialog, bool value);
         private static _FileDialogSetChangePath _FileDialogSetChangePathFunc;
         internal static void FileDialogSetChangePath(IntPtr fileDialog, bool value)
         {
            if (_FileDialogSetChangePathFunc == null)
            {
               _FileDialogSetChangePathFunc =
                  (_FileDialogSetChangePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogSetChangePath"), typeof(_FileDialogSetChangePath));
            }

            _FileDialogSetChangePathFunc(fileDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileDialogCreateInstance();
         private static _FileDialogCreateInstance _FileDialogCreateInstanceFunc;
         internal static IntPtr FileDialogCreateInstance()
         {
            if (_FileDialogCreateInstanceFunc == null)
            {
               _FileDialogCreateInstanceFunc =
                  (_FileDialogCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogCreateInstance"), typeof(_FileDialogCreateInstance));
            }

            return _FileDialogCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _FileDialogExecute(IntPtr fileDialog);
         private static _FileDialogExecute _FileDialogExecuteFunc;
         internal static bool FileDialogExecute(IntPtr fileDialog)
         {
            if (_FileDialogExecuteFunc == null)
            {
               _FileDialogExecuteFunc =
                  (_FileDialogExecute)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "FileDialogExecute"), typeof(_FileDialogExecute));
            }

            return _FileDialogExecuteFunc(fileDialog);
         }
      }
      
      #endregion

      #region Properties

      public string DefaultPath
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.FileDialogGetDefaultPath(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.FileDialogSetDefaultPath(ObjectPtr->ObjPtr, value);
         }
      }
      public string DefaultFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.FileDialogGetDefaultFile(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.FileDialogSetDefaultFile(ObjectPtr->ObjPtr, value);
         }
      }
      public string FileName
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.FileDialogGetFileName(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.FileDialogSetFileName(ObjectPtr->ObjPtr, value);
         }
      }
      public string Filters
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.FileDialogGetFilters(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.FileDialogSetFilters(ObjectPtr->ObjPtr, value);
         }
      }
      public string Title
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.FileDialogGetTitle(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.FileDialogSetTitle(ObjectPtr->ObjPtr, value);
         }
      }
      public bool ChangePath
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.FileDialogGetChangePath(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.FileDialogSetChangePath(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public bool Execute()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.FileDialogExecute(ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}