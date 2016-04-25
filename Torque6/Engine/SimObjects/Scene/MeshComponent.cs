using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects.Scene
{
   public unsafe class MeshComponent : BaseComponent
   {
      
      public MeshComponent()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MeshComponentCreateInstance());
      }

      public MeshComponent(uint pId) : base(pId)
      {
      }

      public MeshComponent(string pName) : base(pName)
      {
      }

      public MeshComponent(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public MeshComponent(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public MeshComponent(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string MeshComponentGetMeshAsset(IntPtr MeshComponent);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void MeshComponentSetMeshAsset(IntPtr MeshComponent, string meshAssetId);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr MeshComponentCreateInstance();
      }
      
      #endregion

      #region Properties

      public string MeshAsset
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.MeshComponentGetMeshAsset(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.MeshComponentSetMeshAsset(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}