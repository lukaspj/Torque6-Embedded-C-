using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ModuleMergeDefinition : SimObject
   {
      
      public ModuleMergeDefinition()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ModuleMergeDefinitionCreateInstance());
      }

      public ModuleMergeDefinition(uint pId) : base(pId)
      {
      }

      public ModuleMergeDefinition(string pName) : base(pName)
      {
      }

      public ModuleMergeDefinition(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ModuleMergeDefinition(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ModuleMergeDefinition(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleMergeDefinitionGetMergePath(IntPtr mergeDefinition);
         private static _ModuleMergeDefinitionGetMergePath _ModuleMergeDefinitionGetMergePathFunc;
         internal static IntPtr ModuleMergeDefinitionGetMergePath(IntPtr mergeDefinition)
         {
            if (_ModuleMergeDefinitionGetMergePathFunc == null)
            {
               _ModuleMergeDefinitionGetMergePathFunc =
                  (_ModuleMergeDefinitionGetMergePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleMergeDefinitionGetMergePath"), typeof(_ModuleMergeDefinitionGetMergePath));
            }

            return _ModuleMergeDefinitionGetMergePathFunc(mergeDefinition);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ModuleMergeDefinitionSetMergePath(IntPtr mergeDefinition, string value);
         private static _ModuleMergeDefinitionSetMergePath _ModuleMergeDefinitionSetMergePathFunc;
         internal static void ModuleMergeDefinitionSetMergePath(IntPtr mergeDefinition, string value)
         {
            if (_ModuleMergeDefinitionSetMergePathFunc == null)
            {
               _ModuleMergeDefinitionSetMergePathFunc =
                  (_ModuleMergeDefinitionSetMergePath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleMergeDefinitionSetMergePath"), typeof(_ModuleMergeDefinitionSetMergePath));
            }

            _ModuleMergeDefinitionSetMergePathFunc(mergeDefinition, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ModuleMergeDefinitionCreateInstance();
         private static _ModuleMergeDefinitionCreateInstance _ModuleMergeDefinitionCreateInstanceFunc;
         internal static IntPtr ModuleMergeDefinitionCreateInstance()
         {
            if (_ModuleMergeDefinitionCreateInstanceFunc == null)
            {
               _ModuleMergeDefinitionCreateInstanceFunc =
                  (_ModuleMergeDefinitionCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ModuleMergeDefinitionCreateInstance"), typeof(_ModuleMergeDefinitionCreateInstance));
            }

            return _ModuleMergeDefinitionCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string MergePath
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ModuleMergeDefinitionGetMergePath(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ModuleMergeDefinitionSetMergePath(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}