using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class SaveFileDialog : FileDialog
   {
      
      public SaveFileDialog()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SaveFileDialogCreateInstance());
      }

      public SaveFileDialog(uint pId) : base(pId)
      {
      }

      public SaveFileDialog(string pName) : base(pName)
      {
      }

      public SaveFileDialog(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SaveFileDialog(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SaveFileDialog(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SaveFileDialogGetOverwritePrompt(IntPtr saveFileDialog);
         private static _SaveFileDialogGetOverwritePrompt _SaveFileDialogGetOverwritePromptFunc;
         internal static bool SaveFileDialogGetOverwritePrompt(IntPtr saveFileDialog)
         {
            if (_SaveFileDialogGetOverwritePromptFunc == null)
            {
               _SaveFileDialogGetOverwritePromptFunc =
                  (_SaveFileDialogGetOverwritePrompt)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SaveFileDialogGetOverwritePrompt"), typeof(_SaveFileDialogGetOverwritePrompt));
            }

            return _SaveFileDialogGetOverwritePromptFunc(saveFileDialog);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SaveFileDialogSetOverwritePrompt(IntPtr saveFileDialog, bool value);
         private static _SaveFileDialogSetOverwritePrompt _SaveFileDialogSetOverwritePromptFunc;
         internal static void SaveFileDialogSetOverwritePrompt(IntPtr saveFileDialog, bool value)
         {
            if (_SaveFileDialogSetOverwritePromptFunc == null)
            {
               _SaveFileDialogSetOverwritePromptFunc =
                  (_SaveFileDialogSetOverwritePrompt)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SaveFileDialogSetOverwritePrompt"), typeof(_SaveFileDialogSetOverwritePrompt));
            }

            _SaveFileDialogSetOverwritePromptFunc(saveFileDialog, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SaveFileDialogCreateInstance();
         private static _SaveFileDialogCreateInstance _SaveFileDialogCreateInstanceFunc;
         internal static IntPtr SaveFileDialogCreateInstance()
         {
            if (_SaveFileDialogCreateInstanceFunc == null)
            {
               _SaveFileDialogCreateInstanceFunc =
                  (_SaveFileDialogCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SaveFileDialogCreateInstance"), typeof(_SaveFileDialogCreateInstance));
            }

            return _SaveFileDialogCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public bool OverwritePrompt
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.SaveFileDialogGetOverwritePrompt(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.SaveFileDialogSetOverwritePrompt(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}