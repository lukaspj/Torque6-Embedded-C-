using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ShaderAsset : AssetBase
   {
      
      public ShaderAsset()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ShaderAssetCreateInstance());
      }

      public ShaderAsset(uint pId) : base(pId)
      {
      }

      public ShaderAsset(string pName) : base(pName)
      {
      }

      public ShaderAsset(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ShaderAsset(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ShaderAsset(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void ShaderAssetSetVertexShaderFile(IntPtr shaderAsset, string val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern void ShaderAssetSetPixelShaderFile(IntPtr shaderAsset, string val);

         [DllImport("Torque6_DEBUG", CallingConvention = CallingConvention.Cdecl)]
         internal static extern IntPtr ShaderAssetCreateInstance();
      }
      
      #endregion

      #region Properties

      public string VertexShaderFile
      {
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ShaderAssetSetVertexShaderFile(ObjectPtr->ObjPtr, value);
         }
      }
      public string PixelShaderFile
      {
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ShaderAssetSetPixelShaderFile(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}