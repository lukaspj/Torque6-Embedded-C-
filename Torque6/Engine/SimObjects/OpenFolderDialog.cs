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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr OpenFolderDialogGetFileMustExist(IntPtr openFolderDialog);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void OpenFolderDialogSetFileMustExist(IntPtr openFolderDialog, string value);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr OpenFolderDialogCreateInstance();
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