using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ReferencedAssets : SimObject
   {
      
      public ReferencedAssets()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ReferencedAssetsCreateInstance());
      }

      public ReferencedAssets(uint pId) : base(pId)
      {
      }

      public ReferencedAssets(string pName) : base(pName)
      {
      }

      public ReferencedAssets(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ReferencedAssets(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ReferencedAssets(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ReferencedAssetsGetPath(IntPtr assets);
         private static _ReferencedAssetsGetPath _ReferencedAssetsGetPathFunc;
         internal static IntPtr ReferencedAssetsGetPath(IntPtr assets)
         {
            if (_ReferencedAssetsGetPathFunc == null)
            {
               _ReferencedAssetsGetPathFunc =
                  (_ReferencedAssetsGetPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ReferencedAssetsGetPath"), typeof(_ReferencedAssetsGetPath));
            }

            return _ReferencedAssetsGetPathFunc(assets);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ReferencedAssetsSetPath(IntPtr assets, string path);
         private static _ReferencedAssetsSetPath _ReferencedAssetsSetPathFunc;
         internal static void ReferencedAssetsSetPath(IntPtr assets, string path)
         {
            if (_ReferencedAssetsSetPathFunc == null)
            {
               _ReferencedAssetsSetPathFunc =
                  (_ReferencedAssetsSetPath)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ReferencedAssetsSetPath"), typeof(_ReferencedAssetsSetPath));
            }

            _ReferencedAssetsSetPathFunc(assets, path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ReferencedAssetsGetExtension(IntPtr assets);
         private static _ReferencedAssetsGetExtension _ReferencedAssetsGetExtensionFunc;
         internal static IntPtr ReferencedAssetsGetExtension(IntPtr assets)
         {
            if (_ReferencedAssetsGetExtensionFunc == null)
            {
               _ReferencedAssetsGetExtensionFunc =
                  (_ReferencedAssetsGetExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ReferencedAssetsGetExtension"), typeof(_ReferencedAssetsGetExtension));
            }

            return _ReferencedAssetsGetExtensionFunc(assets);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ReferencedAssetsSetExtension(IntPtr assets, string path);
         private static _ReferencedAssetsSetExtension _ReferencedAssetsSetExtensionFunc;
         internal static void ReferencedAssetsSetExtension(IntPtr assets, string path)
         {
            if (_ReferencedAssetsSetExtensionFunc == null)
            {
               _ReferencedAssetsSetExtensionFunc =
                  (_ReferencedAssetsSetExtension)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ReferencedAssetsSetExtension"), typeof(_ReferencedAssetsSetExtension));
            }

            _ReferencedAssetsSetExtensionFunc(assets, path);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ReferencedAssetsGetRecurse(IntPtr assets);
         private static _ReferencedAssetsGetRecurse _ReferencedAssetsGetRecurseFunc;
         internal static bool ReferencedAssetsGetRecurse(IntPtr assets)
         {
            if (_ReferencedAssetsGetRecurseFunc == null)
            {
               _ReferencedAssetsGetRecurseFunc =
                  (_ReferencedAssetsGetRecurse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ReferencedAssetsGetRecurse"), typeof(_ReferencedAssetsGetRecurse));
            }

            return _ReferencedAssetsGetRecurseFunc(assets);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ReferencedAssetsSetRecurse(IntPtr assets, bool value);
         private static _ReferencedAssetsSetRecurse _ReferencedAssetsSetRecurseFunc;
         internal static void ReferencedAssetsSetRecurse(IntPtr assets, bool value)
         {
            if (_ReferencedAssetsSetRecurseFunc == null)
            {
               _ReferencedAssetsSetRecurseFunc =
                  (_ReferencedAssetsSetRecurse)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ReferencedAssetsSetRecurse"), typeof(_ReferencedAssetsSetRecurse));
            }

            _ReferencedAssetsSetRecurseFunc(assets, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ReferencedAssetsCreateInstance();
         private static _ReferencedAssetsCreateInstance _ReferencedAssetsCreateInstanceFunc;
         internal static IntPtr ReferencedAssetsCreateInstance()
         {
            if (_ReferencedAssetsCreateInstanceFunc == null)
            {
               _ReferencedAssetsCreateInstanceFunc =
                  (_ReferencedAssetsCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ReferencedAssetsCreateInstance"), typeof(_ReferencedAssetsCreateInstance));
            }

            return _ReferencedAssetsCreateInstanceFunc();
         }
      }
      
      #endregion

      #region Properties

      public string Path
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ReferencedAssetsGetPath(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ReferencedAssetsSetPath(ObjectPtr->ObjPtr, value);
         }
      }
      public string Extension
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ReferencedAssetsGetExtension(ObjectPtr->ObjPtr));
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ReferencedAssetsSetExtension(ObjectPtr->ObjPtr, value);
         }
      }
      public bool Recurse
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.ReferencedAssetsGetRecurse(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.ReferencedAssetsSetRecurse(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      
      
      #endregion

      
   }
}