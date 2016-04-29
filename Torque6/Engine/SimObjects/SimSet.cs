using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class SimSet : SimObject
   {
      
      public SimSet()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.SimSetCreateInstance());
      }

      public SimSet(uint pId) : base(pId)
      {
      }

      public SimSet(string pName) : base(pName)
      {
      }

      public SimSet(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public SimSet(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public SimSet(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimSetCreateInstance();
         private static _SimSetCreateInstance _SimSetCreateInstanceFunc;
         internal static IntPtr SimSetCreateInstance()
         {
            if (_SimSetCreateInstanceFunc == null)
            {
               _SimSetCreateInstanceFunc =
                  (_SimSetCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetCreateInstance"), typeof(_SimSetCreateInstance));
            }

            return _SimSetCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimSetListObjects(IntPtr set);
         private static _SimSetListObjects _SimSetListObjectsFunc;
         internal static void SimSetListObjects(IntPtr set)
         {
            if (_SimSetListObjectsFunc == null)
            {
               _SimSetListObjectsFunc =
                  (_SimSetListObjects)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetListObjects"), typeof(_SimSetListObjects));
            }

            _SimSetListObjectsFunc(set);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimSetAdd(IntPtr set, IntPtr obj);
         private static _SimSetAdd _SimSetAddFunc;
         internal static void SimSetAdd(IntPtr set, IntPtr obj)
         {
            if (_SimSetAddFunc == null)
            {
               _SimSetAddFunc =
                  (_SimSetAdd)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetAdd"), typeof(_SimSetAdd));
            }

            _SimSetAddFunc(set, obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimSetRemove(IntPtr set, IntPtr obj);
         private static _SimSetRemove _SimSetRemoveFunc;
         internal static void SimSetRemove(IntPtr set, IntPtr obj)
         {
            if (_SimSetRemoveFunc == null)
            {
               _SimSetRemoveFunc =
                  (_SimSetRemove)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetRemove"), typeof(_SimSetRemove));
            }

            _SimSetRemoveFunc(set, obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimSetDeleteObjects(IntPtr set);
         private static _SimSetDeleteObjects _SimSetDeleteObjectsFunc;
         internal static void SimSetDeleteObjects(IntPtr set)
         {
            if (_SimSetDeleteObjectsFunc == null)
            {
               _SimSetDeleteObjectsFunc =
                  (_SimSetDeleteObjects)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetDeleteObjects"), typeof(_SimSetDeleteObjects));
            }

            _SimSetDeleteObjectsFunc(set);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimSetClear(IntPtr set);
         private static _SimSetClear _SimSetClearFunc;
         internal static void SimSetClear(IntPtr set)
         {
            if (_SimSetClearFunc == null)
            {
               _SimSetClearFunc =
                  (_SimSetClear)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetClear"), typeof(_SimSetClear));
            }

            _SimSetClearFunc(set);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimSetCallOnChildren(IntPtr set, string method, int argc, string[] argv);
         private static _SimSetCallOnChildren _SimSetCallOnChildrenFunc;
         internal static void SimSetCallOnChildren(IntPtr set, string method, int argc, string[] argv)
         {
            if (_SimSetCallOnChildrenFunc == null)
            {
               _SimSetCallOnChildrenFunc =
                  (_SimSetCallOnChildren)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetCallOnChildren"), typeof(_SimSetCallOnChildren));
            }

            _SimSetCallOnChildrenFunc(set, method, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimSetReorderChild(IntPtr set, IntPtr obj1, IntPtr obj2);
         private static _SimSetReorderChild _SimSetReorderChildFunc;
         internal static void SimSetReorderChild(IntPtr set, IntPtr obj1, IntPtr obj2)
         {
            if (_SimSetReorderChildFunc == null)
            {
               _SimSetReorderChildFunc =
                  (_SimSetReorderChild)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetReorderChild"), typeof(_SimSetReorderChild));
            }

            _SimSetReorderChildFunc(set, obj1, obj2);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SimSetGetCount(IntPtr set);
         private static _SimSetGetCount _SimSetGetCountFunc;
         internal static int SimSetGetCount(IntPtr set)
         {
            if (_SimSetGetCountFunc == null)
            {
               _SimSetGetCountFunc =
                  (_SimSetGetCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetGetCount"), typeof(_SimSetGetCount));
            }

            return _SimSetGetCountFunc(set);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimSetGetObject(IntPtr set, int index);
         private static _SimSetGetObject _SimSetGetObjectFunc;
         internal static IntPtr SimSetGetObject(IntPtr set, int index)
         {
            if (_SimSetGetObjectFunc == null)
            {
               _SimSetGetObjectFunc =
                  (_SimSetGetObject)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetGetObject"), typeof(_SimSetGetObject));
            }

            return _SimSetGetObjectFunc(set, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _SimSetIsMember(IntPtr set, IntPtr obj);
         private static _SimSetIsMember _SimSetIsMemberFunc;
         internal static bool SimSetIsMember(IntPtr set, IntPtr obj)
         {
            if (_SimSetIsMemberFunc == null)
            {
               _SimSetIsMemberFunc =
                  (_SimSetIsMember)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetIsMember"), typeof(_SimSetIsMember));
            }

            return _SimSetIsMemberFunc(set, obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimSetFindObjectByInternalName(IntPtr set, string name, bool searchChildren);
         private static _SimSetFindObjectByInternalName _SimSetFindObjectByInternalNameFunc;
         internal static IntPtr SimSetFindObjectByInternalName(IntPtr set, string name, bool searchChildren)
         {
            if (_SimSetFindObjectByInternalNameFunc == null)
            {
               _SimSetFindObjectByInternalNameFunc =
                  (_SimSetFindObjectByInternalName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetFindObjectByInternalName"), typeof(_SimSetFindObjectByInternalName));
            }

            return _SimSetFindObjectByInternalNameFunc(set, name, searchChildren);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimSetBringToFront(IntPtr set, IntPtr obj);
         private static _SimSetBringToFront _SimSetBringToFrontFunc;
         internal static void SimSetBringToFront(IntPtr set, IntPtr obj)
         {
            if (_SimSetBringToFrontFunc == null)
            {
               _SimSetBringToFrontFunc =
                  (_SimSetBringToFront)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetBringToFront"), typeof(_SimSetBringToFront));
            }

            _SimSetBringToFrontFunc(set, obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _SimSetPushToBack(IntPtr set, IntPtr obj);
         private static _SimSetPushToBack _SimSetPushToBackFunc;
         internal static void SimSetPushToBack(IntPtr set, IntPtr obj)
         {
            if (_SimSetPushToBackFunc == null)
            {
               _SimSetPushToBackFunc =
                  (_SimSetPushToBack)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "SimSetPushToBack"), typeof(_SimSetPushToBack));
            }

            _SimSetPushToBackFunc(set, obj);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void ListObjects()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimSetListObjects(ObjectPtr->ObjPtr);
      }

      public void Add(SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimSetAdd(ObjectPtr->ObjPtr, obj.ObjectPtr->ObjPtr);
      }

      public void Remove(SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimSetRemove(ObjectPtr->ObjPtr, obj.ObjectPtr->ObjPtr);
      }

      public void DeleteObjects()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimSetDeleteObjects(ObjectPtr->ObjPtr);
      }

      public void Clear()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimSetClear(ObjectPtr->ObjPtr);
      }

      public void CallOnChildren(string method, int argc, string[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimSetCallOnChildren(ObjectPtr->ObjPtr, method, argc, argv);
      }

      public void ReorderChild(SimObject obj1, SimObject obj2)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimSetReorderChild(ObjectPtr->ObjPtr, obj1.ObjectPtr->ObjPtr, obj2.ObjectPtr->ObjPtr);
      }

      public int GetCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimSetGetCount(ObjectPtr->ObjPtr);
      }

      public SimObject GetObject(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimObject(InternalUnsafeMethods.SimSetGetObject(ObjectPtr->ObjPtr, index));
      }

      public bool IsMember(SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.SimSetIsMember(ObjectPtr->ObjPtr, obj.ObjectPtr->ObjPtr);
      }

      public SimObject FindObjectByInternalName(string name, bool searchChildren = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return new SimObject(InternalUnsafeMethods.SimSetFindObjectByInternalName(ObjectPtr->ObjPtr, name, searchChildren));
      }

      public void BringToFront(SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimSetBringToFront(ObjectPtr->ObjPtr, obj.ObjectPtr->ObjPtr);
      }

      public void PushToBack(SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.SimSetPushToBack(ObjectPtr->ObjPtr, obj.ObjectPtr->ObjPtr);
      }
      
      #endregion

      
   }
}