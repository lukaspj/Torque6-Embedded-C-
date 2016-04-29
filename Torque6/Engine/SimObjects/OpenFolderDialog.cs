using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class OpenFolderDialog : OpenFileDialog
   {
      
      public OpenFolderDialog()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.OpenFolderDialogCreateInstance());
      }

      public OpenFolderDialog(uint pId) : base(pId)
      {
      }

      public OpenFolderDialog(string pName) : base(pName)
      {
      }

      public OpenFolderDialog(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public OpenFolderDialog(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public OpenFolderDialog(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpenFolderDialogGetFileMustExist(IntPtr openFolderDialog);
         private static _OpenFolderDialogGetFileMustExist _OpenFolderDialogGetFileMustExistFunc;
         internal static IntPtr OpenFolderDialogGetFileMustExist(IntPtr openFolderDialog)
         {
            if (_OpenFolderDialogGetFileMustExistFunc == null)
            {
               _OpenFolderDialogGetFileMustExistFunc =
                  (_OpenFolderDialogGetFileMustExist)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpenFolderDialogGetFileMustExist"), typeof(_OpenFolderDialogGetFileMustExist));
            }

            return _OpenFolderDialogGetFileMustExistFunc(openFolderDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _OpenFolderDialogSetFileMustExist(IntPtr openFolderDialog, string value);
         private static _OpenFolderDialogSetFileMustExist _OpenFolderDialogSetFileMustExistFunc;
         internal static void OpenFolderDialogSetFileMustExist(IntPtr openFolderDialog, string value)
         {
            if (_OpenFolderDialogSetFileMustExistFunc == null)
            {
               _OpenFolderDialogSetFileMustExistFunc =
                  (_OpenFolderDialogSetFileMustExist)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpenFolderDialogSetFileMustExist"), typeof(_OpenFolderDialogSetFileMustExist));
            }

            _OpenFolderDialogSetFileMustExistFunc(openFolderDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OpenFolderDialogCreateInstance();
         private static _OpenFolderDialogCreateInstance _OpenFolderDialogCreateInstanceFunc;
         internal static IntPtr OpenFolderDialogCreateInstance()
         {
            if (_OpenFolderDialogCreateInstanceFunc == null)
            {
               _OpenFolderDialogCreateInstanceFunc =
                  (_OpenFolderDialogCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "OpenFolderDialogCreateInstance"), typeof(_OpenFolderDialogCreateInstance));
            }

            return _OpenFolderDialogCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string FileMustExist
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.OpenFolderDialogGetFileMustExist(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.OpenFolderDialogSetFileMustExist(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}