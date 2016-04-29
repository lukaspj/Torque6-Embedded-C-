using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class OpenFileDialog : FileDialog
   {
      
      public OpenFileDialog()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.OpenFileDialogCreateInstance());
      }

      public OpenFileDialog(uint pId) : base(pId)
      {
      }

      public OpenFileDialog(string pName) : base(pName)
      {
      }

      public OpenFileDialog(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public OpenFileDialog(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public OpenFileDialog(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _OpenFileDialogGetMustExist(IntPtr openFileDialog);
         private static _OpenFileDialogGetMustExist _OpenFileDialogGetMustExistFunc;
         internal static bool OpenFileDialogGetMustExist(IntPtr openFileDialog)
         {
            if (_OpenFileDialogGetMustExistFunc == null)
            {
               _OpenFileDialogGetMustExistFunc =
                  (_OpenFileDialogGetMustExist)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpenFileDialogGetMustExist"), typeof(_OpenFileDialogGetMustExist));
            }

            return _OpenFileDialogGetMustExistFunc(openFileDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _OpenFileDialogSetMustExist(IntPtr openFileDialog, bool value);
         private static _OpenFileDialogSetMustExist _OpenFileDialogSetMustExistFunc;
         internal static void OpenFileDialogSetMustExist(IntPtr openFileDialog, bool value)
         {
            if (_OpenFileDialogSetMustExistFunc == null)
            {
               _OpenFileDialogSetMustExistFunc =
                  (_OpenFileDialogSetMustExist)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpenFileDialogSetMustExist"), typeof(_OpenFileDialogSetMustExist));
            }

            _OpenFileDialogSetMustExistFunc(openFileDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _OpenFileDialogGetMultipleFiles(IntPtr openFileDialog);
         private static _OpenFileDialogGetMultipleFiles _OpenFileDialogGetMultipleFilesFunc;
         internal static bool OpenFileDialogGetMultipleFiles(IntPtr openFileDialog)
         {
            if (_OpenFileDialogGetMultipleFilesFunc == null)
            {
               _OpenFileDialogGetMultipleFilesFunc =
                  (_OpenFileDialogGetMultipleFiles)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpenFileDialogGetMultipleFiles"), typeof(_OpenFileDialogGetMultipleFiles));
            }

            return _OpenFileDialogGetMultipleFilesFunc(openFileDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _OpenFileDialogSetMultipleFiles(IntPtr openFileDialog, bool value);
         private static _OpenFileDialogSetMultipleFiles _OpenFileDialogSetMultipleFilesFunc;
         internal static void OpenFileDialogSetMultipleFiles(IntPtr openFileDialog, bool value)
         {
            if (_OpenFileDialogSetMultipleFilesFunc == null)
            {
               _OpenFileDialogSetMultipleFilesFunc =
                  (_OpenFileDialogSetMultipleFiles)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpenFileDialogSetMultipleFiles"), typeof(_OpenFileDialogSetMultipleFiles));
            }

            _OpenFileDialogSetMultipleFilesFunc(openFileDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpenFileDialogCreateInstance();
         private static _OpenFileDialogCreateInstance _OpenFileDialogCreateInstanceFunc;
         internal static IntPtr OpenFileDialogCreateInstance()
         {
            if (_OpenFileDialogCreateInstanceFunc == null)
            {
               _OpenFileDialogCreateInstanceFunc =
                  (_OpenFileDialogCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpenFileDialogCreateInstance"), typeof(_OpenFileDialogCreateInstance));
            }

            return _OpenFileDialogCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public bool MustExist
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.OpenFileDialogGetMustExist(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.OpenFileDialogSetMustExist(ObjectPtr->ObjPtr, value);
         }
      }
      public bool MultipleFiles
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.OpenFileDialogGetMultipleFiles(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.OpenFileDialogSetMultipleFiles(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}