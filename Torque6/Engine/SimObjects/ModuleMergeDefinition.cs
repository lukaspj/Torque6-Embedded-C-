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
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string ModuleMergeDefinitionGetMergePath(IntPtr mergeDefinition);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void ModuleMergeDefinitionSetMergePath(IntPtr mergeDefinition, string value);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr ModuleMergeDefinitionCreateInstance();
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