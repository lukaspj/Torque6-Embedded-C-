using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class MaterialAsset : AssetBase
   {
      
      public MaterialAsset()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.MaterialAssetCreateInstance());
      }

      public MaterialAsset(uint pId) : base(pId)
      {
      }

      public MaterialAsset(string pName) : base(pName)
      {
      }

      public MaterialAsset(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public MaterialAsset(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public MaterialAsset(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern string MaterialAssetGetTemplateFile(IntPtr materialAsset);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr MaterialAssetCreateInstance();
      }
      
      #endregion

      #region Properties

      public string TemplateFile
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.MaterialAssetGetTemplateFile(ObjectPtr->ObjPtr);
         }

      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}