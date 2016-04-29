using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class HTTPObject : TCPObject
   {
      
      public HTTPObject()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.HTTPObjectCreateInstance());
      }

      public HTTPObject(uint pId) : base(pId)
      {
      }

      public HTTPObject(string pName) : base(pName)
      {
      }

      public HTTPObject(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public HTTPObject(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public HTTPObject(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _HTTPObjectCreateInstance();
         private static _HTTPObjectCreateInstance _HTTPObjectCreateInstanceFunc;
         internal static IntPtr HTTPObjectCreateInstance()
         {
            if (_HTTPObjectCreateInstanceFunc == null)
            {
               _HTTPObjectCreateInstanceFunc =
                  (_HTTPObjectCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "HTTPObjectCreateInstance"), typeof(_HTTPObjectCreateInstance));
            }

            return _HTTPObjectCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _HTTPObjectGet(IntPtr httpObj, string address, string requestURI, string query);
         private static _HTTPObjectGet _HTTPObjectGetFunc;
         internal static void HTTPObjectGet(IntPtr httpObj, string address, string requestURI, string query)
         {
            if (_HTTPObjectGetFunc == null)
            {
               _HTTPObjectGetFunc =
                  (_HTTPObjectGet)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "HTTPObjectGet"), typeof(_HTTPObjectGet));
            }

            _HTTPObjectGetFunc(httpObj, address, requestURI, query);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _HTTPObjectPost(IntPtr httpObj, string address, string requestURI, string query, string post);
         private static _HTTPObjectPost _HTTPObjectPostFunc;
         internal static void HTTPObjectPost(IntPtr httpObj, string address, string requestURI, string query, string post)
         {
            if (_HTTPObjectPostFunc == null)
            {
               _HTTPObjectPostFunc =
                  (_HTTPObjectPost)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "HTTPObjectPost"), typeof(_HTTPObjectPost));
            }

            _HTTPObjectPostFunc(httpObj, address, requestURI, query, post);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void Get(string address, string requestURI, string query = null)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.HTTPObjectGet(ObjectPtr->ObjPtr, address, requestURI, query);
      }

      public void Post(string address, string requestURI, string query, string post)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.HTTPObjectPost(ObjectPtr->ObjPtr, address, requestURI, query, post);
      }
      
      #endregion

      
   }
}