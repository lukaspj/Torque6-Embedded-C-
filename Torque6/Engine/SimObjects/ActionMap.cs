using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class ActionMap : SimObject
   {
      
      public ActionMap()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.ActionMapCreateInstance());
      }

      public ActionMap(uint pId) : base(pId)
      {
      }

      public ActionMap(string pName) : base(pName)
      {
      }

      public ActionMap(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public ActionMap(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public ActionMap(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ActionMapCreateInstance();
         private static _ActionMapCreateInstance _ActionMapCreateInstanceFunc;
         internal static IntPtr ActionMapCreateInstance()
         {
            if (_ActionMapCreateInstanceFunc == null)
            {
               _ActionMapCreateInstanceFunc =
                  (_ActionMapCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapCreateInstance"), typeof(_ActionMapCreateInstance));
            }

            return _ActionMapCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ActionMapBind(IntPtr map, int argc, string[] argv);
         private static _ActionMapBind _ActionMapBindFunc;
         internal static void ActionMapBind(IntPtr map, int argc, string[] argv)
         {
            if (_ActionMapBindFunc == null)
            {
               _ActionMapBindFunc =
                  (_ActionMapBind)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapBind"), typeof(_ActionMapBind));
            }

            _ActionMapBindFunc(map, argc, argv);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ActionMapBindObj(IntPtr map, int argc, string[] argv, IntPtr obj);
         private static _ActionMapBindObj _ActionMapBindObjFunc;
         internal static void ActionMapBindObj(IntPtr map, int argc, string[] argv, IntPtr obj)
         {
            if (_ActionMapBindObjFunc == null)
            {
               _ActionMapBindObjFunc =
                  (_ActionMapBindObj)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapBindObj"), typeof(_ActionMapBindObj));
            }

            _ActionMapBindObjFunc(map, argc, argv, obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ActionMapBindCmd(IntPtr map, string device, string action, string makeCmd, string breakCmd);
         private static _ActionMapBindCmd _ActionMapBindCmdFunc;
         internal static void ActionMapBindCmd(IntPtr map, string device, string action, string makeCmd, string breakCmd)
         {
            if (_ActionMapBindCmdFunc == null)
            {
               _ActionMapBindCmdFunc =
                  (_ActionMapBindCmd)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapBindCmd"), typeof(_ActionMapBindCmd));
            }

            _ActionMapBindCmdFunc(map, device, action, makeCmd, breakCmd);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ActionMapUnbind(IntPtr map, string device, string action);
         private static _ActionMapUnbind _ActionMapUnbindFunc;
         internal static void ActionMapUnbind(IntPtr map, string device, string action)
         {
            if (_ActionMapUnbindFunc == null)
            {
               _ActionMapUnbindFunc =
                  (_ActionMapUnbind)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapUnbind"), typeof(_ActionMapUnbind));
            }

            _ActionMapUnbindFunc(map, device, action);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ActionMapUnbindObj(IntPtr map, string device, string action, IntPtr obj);
         private static _ActionMapUnbindObj _ActionMapUnbindObjFunc;
         internal static void ActionMapUnbindObj(IntPtr map, string device, string action, IntPtr obj)
         {
            if (_ActionMapUnbindObjFunc == null)
            {
               _ActionMapUnbindObjFunc =
                  (_ActionMapUnbindObj)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapUnbindObj"), typeof(_ActionMapUnbindObj));
            }

            _ActionMapUnbindObjFunc(map, device, action, obj);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ActionMapSave(IntPtr map, string fileName, bool append);
         private static _ActionMapSave _ActionMapSaveFunc;
         internal static void ActionMapSave(IntPtr map, string fileName, bool append)
         {
            if (_ActionMapSaveFunc == null)
            {
               _ActionMapSaveFunc =
                  (_ActionMapSave)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapSave"), typeof(_ActionMapSave));
            }

            _ActionMapSaveFunc(map, fileName, append);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ActionMapPush(IntPtr map);
         private static _ActionMapPush _ActionMapPushFunc;
         internal static void ActionMapPush(IntPtr map)
         {
            if (_ActionMapPushFunc == null)
            {
               _ActionMapPushFunc =
                  (_ActionMapPush)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapPush"), typeof(_ActionMapPush));
            }

            _ActionMapPushFunc(map);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ActionMapPop(IntPtr map);
         private static _ActionMapPop _ActionMapPopFunc;
         internal static void ActionMapPop(IntPtr map)
         {
            if (_ActionMapPopFunc == null)
            {
               _ActionMapPopFunc =
                  (_ActionMapPop)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapPop"), typeof(_ActionMapPop));
            }

            _ActionMapPopFunc(map);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ActionMapGetBinding(IntPtr map, string command);
         private static _ActionMapGetBinding _ActionMapGetBindingFunc;
         internal static IntPtr ActionMapGetBinding(IntPtr map, string command)
         {
            if (_ActionMapGetBindingFunc == null)
            {
               _ActionMapGetBindingFunc =
                  (_ActionMapGetBinding)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapGetBinding"), typeof(_ActionMapGetBinding));
            }

            return _ActionMapGetBindingFunc(map, command);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ActionMapGetCommand(IntPtr map, string device, string action);
         private static _ActionMapGetCommand _ActionMapGetCommandFunc;
         internal static IntPtr ActionMapGetCommand(IntPtr map, string device, string action)
         {
            if (_ActionMapGetCommandFunc == null)
            {
               _ActionMapGetCommandFunc =
                  (_ActionMapGetCommand)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapGetCommand"), typeof(_ActionMapGetCommand));
            }

            return _ActionMapGetCommandFunc(map, device, action);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate bool _ActionMapIsInverted(IntPtr map, string device, string action);
         private static _ActionMapIsInverted _ActionMapIsInvertedFunc;
         internal static bool ActionMapIsInverted(IntPtr map, string device, string action)
         {
            if (_ActionMapIsInvertedFunc == null)
            {
               _ActionMapIsInvertedFunc =
                  (_ActionMapIsInverted)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapIsInverted"), typeof(_ActionMapIsInverted));
            }

            return _ActionMapIsInvertedFunc(map, device, action);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _ActionMapGetScale(IntPtr map, string device, string action);
         private static _ActionMapGetScale _ActionMapGetScaleFunc;
         internal static float ActionMapGetScale(IntPtr map, string device, string action)
         {
            if (_ActionMapGetScaleFunc == null)
            {
               _ActionMapGetScaleFunc =
                  (_ActionMapGetScale)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapGetScale"), typeof(_ActionMapGetScale));
            }

            return _ActionMapGetScaleFunc(map, device, action);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ActionMapGetDeadZone(IntPtr map, string device, string action);
         private static _ActionMapGetDeadZone _ActionMapGetDeadZoneFunc;
         internal static IntPtr ActionMapGetDeadZone(IntPtr map, string device, string action)
         {
            if (_ActionMapGetDeadZoneFunc == null)
            {
               _ActionMapGetDeadZoneFunc =
                  (_ActionMapGetDeadZone)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "ActionMapGetDeadZone"), typeof(_ActionMapGetDeadZone));
            }

            return _ActionMapGetDeadZoneFunc(map, device, action);
         }
      }
      
      #endregion

      #region Properties

      
      
      #endregion
      
      #region Methods

      public void Bind(int argc, string[] argv)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ActionMapBind(ObjectPtr->ObjPtr, argc, argv);
      }

      public void BindObj(int argc, string[] argv, SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ActionMapBindObj(ObjectPtr->ObjPtr, argc, argv, obj.ObjectPtr->ObjPtr);
      }

      public void BindCmd(string device, string action, string makeCmd, string breakCmd)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ActionMapBindCmd(ObjectPtr->ObjPtr, device, action, makeCmd, breakCmd);
      }

      public void Unbind(string device, string action)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ActionMapUnbind(ObjectPtr->ObjPtr, device, action);
      }

      public void UnbindObj(string device, string action, SimObject obj)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ActionMapUnbindObj(ObjectPtr->ObjPtr, device, action, obj.ObjectPtr->ObjPtr);
      }

      public void Save(string fileName = null, bool append = false)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ActionMapSave(ObjectPtr->ObjPtr, fileName, append);
      }

      public void Push()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ActionMapPush(ObjectPtr->ObjPtr);
      }

      public void Pop()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.ActionMapPop(ObjectPtr->ObjPtr);
      }

      public string GetBinding(string command)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ActionMapGetBinding(ObjectPtr->ObjPtr, command));
      }

      public string GetCommand(string device, string action)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ActionMapGetCommand(ObjectPtr->ObjPtr, device, action));
      }

      public bool IsInverted(string device, string action)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ActionMapIsInverted(ObjectPtr->ObjPtr, device, action);
      }

      public float GetScale(string device, string action)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.ActionMapGetScale(ObjectPtr->ObjPtr, device, action);
      }

      public string GetDeadZone(string device, string action)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.ActionMapGetDeadZone(ObjectPtr->ObjPtr, device, action));
      }
      
      #endregion

      
   }
}