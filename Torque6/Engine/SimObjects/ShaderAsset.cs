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
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ShaderAssetSetVertexShaderFile(IntPtr shaderAsset, string val);
         private static _ShaderAssetSetVertexShaderFile _ShaderAssetSetVertexShaderFileFunc;
         internal static void ShaderAssetSetVertexShaderFile(IntPtr shaderAsset, string val)
         {
            if (_ShaderAssetSetVertexShaderFileFunc == null)
            {
               _ShaderAssetSetVertexShaderFileFunc =
                  (_ShaderAssetSetVertexShaderFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ShaderAssetSetVertexShaderFile"), typeof(_ShaderAssetSetVertexShaderFile));
            }

            _ShaderAssetSetVertexShaderFileFunc(shaderAsset, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ShaderAssetSetPixelShaderFile(IntPtr shaderAsset, string val);
         private static _ShaderAssetSetPixelShaderFile _ShaderAssetSetPixelShaderFileFunc;
         internal static void ShaderAssetSetPixelShaderFile(IntPtr shaderAsset, string val)
         {
            if (_ShaderAssetSetPixelShaderFileFunc == null)
            {
               _ShaderAssetSetPixelShaderFileFunc =
                  (_ShaderAssetSetPixelShaderFile)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ShaderAssetSetPixelShaderFile"), typeof(_ShaderAssetSetPixelShaderFile));
            }

            _ShaderAssetSetPixelShaderFileFunc(shaderAsset, val);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ShaderAssetCreateInstance();
         private static _ShaderAssetCreateInstance _ShaderAssetCreateInstanceFunc;
         internal static IntPtr ShaderAssetCreateInstance()
         {
            if (_ShaderAssetCreateInstanceFunc == null)
            {
               _ShaderAssetCreateInstanceFunc =
                  (_ShaderAssetCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ShaderAssetCreateInstance"), typeof(_ShaderAssetCreateInstance));
            }

            return _ShaderAssetCreateInstanceFunc();
         }
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