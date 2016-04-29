using System;
using System.Linq;
using System.Runtime.InteropServices;
using Torque6.Engine.SimObjects;
using Torque6.Engine.SimObjects.Scene;
using Torque6.Engine.Namespaces;
using Torque6.Utility;

namespace Torque6.Engine.SimObjects
{
   public unsafe class UndoManager : SimObject
   {
      
      public UndoManager()
      {
         ObjectPtr = Sim.WrapObject(InternalUnsafeMethods.UndoManagerCreateInstance());
      }

      public UndoManager(uint pId) : base(pId)
      {
      }

      public UndoManager(string pName) : base(pName)
      {
      }

      public UndoManager(IntPtr pObjPtr) : base(pObjPtr)
      {
      }

      public UndoManager(Sim.SimObjectPtr* pObjPtr) : base(pObjPtr)
      {
      }

      public UndoManager(SimObject pObj) : base(pObj)
      {
      }
      
      #region UnsafeNativeMethods

      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _UndoManagerGetNumLevels(IntPtr undoAction);
         private static _UndoManagerGetNumLevels _UndoManagerGetNumLevelsFunc;
         internal static int UndoManagerGetNumLevels(IntPtr undoAction)
         {
            if (_UndoManagerGetNumLevelsFunc == null)
            {
               _UndoManagerGetNumLevelsFunc =
                  (_UndoManagerGetNumLevels)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerGetNumLevels"), typeof(_UndoManagerGetNumLevels));
            }

            return _UndoManagerGetNumLevelsFunc(undoAction);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _UndoManagerSetNumLevels(IntPtr undoAction, int value);
         private static _UndoManagerSetNumLevels _UndoManagerSetNumLevelsFunc;
         internal static void UndoManagerSetNumLevels(IntPtr undoAction, int value)
         {
            if (_UndoManagerSetNumLevelsFunc == null)
            {
               _UndoManagerSetNumLevelsFunc =
                  (_UndoManagerSetNumLevels)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerSetNumLevels"), typeof(_UndoManagerSetNumLevels));
            }

            _UndoManagerSetNumLevelsFunc(undoAction, value);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoManagerCreateInstance();
         private static _UndoManagerCreateInstance _UndoManagerCreateInstanceFunc;
         internal static IntPtr UndoManagerCreateInstance()
         {
            if (_UndoManagerCreateInstanceFunc == null)
            {
               _UndoManagerCreateInstanceFunc =
                  (_UndoManagerCreateInstance)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerCreateInstance"), typeof(_UndoManagerCreateInstance));
            }

            return _UndoManagerCreateInstanceFunc();
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _UndoManagerGetRedoCount(IntPtr undoManager);
         private static _UndoManagerGetRedoCount _UndoManagerGetRedoCountFunc;
         internal static int UndoManagerGetRedoCount(IntPtr undoManager)
         {
            if (_UndoManagerGetRedoCountFunc == null)
            {
               _UndoManagerGetRedoCountFunc =
                  (_UndoManagerGetRedoCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerGetRedoCount"), typeof(_UndoManagerGetRedoCount));
            }

            return _UndoManagerGetRedoCountFunc(undoManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _UndoManagerClearAll(IntPtr undoManager);
         private static _UndoManagerClearAll _UndoManagerClearAllFunc;
         internal static void UndoManagerClearAll(IntPtr undoManager)
         {
            if (_UndoManagerClearAllFunc == null)
            {
               _UndoManagerClearAllFunc =
                  (_UndoManagerClearAll)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerClearAll"), typeof(_UndoManagerClearAll));
            }

            _UndoManagerClearAllFunc(undoManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _UndoManagerGetUndoCount(IntPtr undoManager);
         private static _UndoManagerGetUndoCount _UndoManagerGetUndoCountFunc;
         internal static int UndoManagerGetUndoCount(IntPtr undoManager)
         {
            if (_UndoManagerGetUndoCountFunc == null)
            {
               _UndoManagerGetUndoCountFunc =
                  (_UndoManagerGetUndoCount)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerGetUndoCount"), typeof(_UndoManagerGetUndoCount));
            }

            return _UndoManagerGetUndoCountFunc(undoManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoManagerGetUndoName(IntPtr undoManager, int index);
         private static _UndoManagerGetUndoName _UndoManagerGetUndoNameFunc;
         internal static IntPtr UndoManagerGetUndoName(IntPtr undoManager, int index)
         {
            if (_UndoManagerGetUndoNameFunc == null)
            {
               _UndoManagerGetUndoNameFunc =
                  (_UndoManagerGetUndoName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerGetUndoName"), typeof(_UndoManagerGetUndoName));
            }

            return _UndoManagerGetUndoNameFunc(undoManager, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoManagerGetRedoName(IntPtr undoManager, int index);
         private static _UndoManagerGetRedoName _UndoManagerGetRedoNameFunc;
         internal static IntPtr UndoManagerGetRedoName(IntPtr undoManager, int index)
         {
            if (_UndoManagerGetRedoNameFunc == null)
            {
               _UndoManagerGetRedoNameFunc =
                  (_UndoManagerGetRedoName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerGetRedoName"), typeof(_UndoManagerGetRedoName));
            }

            return _UndoManagerGetRedoNameFunc(undoManager, index);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _UndoManagerUndo(IntPtr undoManager);
         private static _UndoManagerUndo _UndoManagerUndoFunc;
         internal static void UndoManagerUndo(IntPtr undoManager)
         {
            if (_UndoManagerUndoFunc == null)
            {
               _UndoManagerUndoFunc =
                  (_UndoManagerUndo)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerUndo"), typeof(_UndoManagerUndo));
            }

            _UndoManagerUndoFunc(undoManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _UndoManagerRedo(IntPtr undoManager);
         private static _UndoManagerRedo _UndoManagerRedoFunc;
         internal static void UndoManagerRedo(IntPtr undoManager)
         {
            if (_UndoManagerRedoFunc == null)
            {
               _UndoManagerRedoFunc =
                  (_UndoManagerRedo)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerRedo"), typeof(_UndoManagerRedo));
            }

            _UndoManagerRedoFunc(undoManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoManagerGetNextUndoName(IntPtr undoManager);
         private static _UndoManagerGetNextUndoName _UndoManagerGetNextUndoNameFunc;
         internal static IntPtr UndoManagerGetNextUndoName(IntPtr undoManager)
         {
            if (_UndoManagerGetNextUndoNameFunc == null)
            {
               _UndoManagerGetNextUndoNameFunc =
                  (_UndoManagerGetNextUndoName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerGetNextUndoName"), typeof(_UndoManagerGetNextUndoName));
            }

            return _UndoManagerGetNextUndoNameFunc(undoManager);
         }

         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoManagerGetNextRedoName(IntPtr undoManager);
         private static _UndoManagerGetNextRedoName _UndoManagerGetNextRedoNameFunc;
         internal static IntPtr UndoManagerGetNextRedoName(IntPtr undoManager)
         {
            if (_UndoManagerGetNextRedoNameFunc == null)
            {
               _UndoManagerGetNextRedoNameFunc =
                  (_UndoManagerGetNextRedoName)Marshal.GetDelegateForFunctionPointer(Interop.Torque6.DllLoadUtils.GetProcAddress(Interop.Torque6.Torque6LibHandle,
                     "UndoManagerGetNextRedoName"), typeof(_UndoManagerGetNextRedoName));
            }

            return _UndoManagerGetNextRedoNameFunc(undoManager);
         }
      }
      
      #endregion

      #region Properties

      public int NumLevels
      {
         get
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            return InternalUnsafeMethods.UndoManagerGetNumLevels(ObjectPtr->ObjPtr);
         }
         set
         {
            if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
            InternalUnsafeMethods.UndoManagerSetNumLevels(ObjectPtr->ObjPtr, value);
         }
      }
      
      #endregion
      
      #region Methods

      public int GetRedoCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.UndoManagerGetRedoCount(ObjectPtr->ObjPtr);
      }

      public void ClearAll()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.UndoManagerClearAll(ObjectPtr->ObjPtr);
      }

      public int GetUndoCount()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return InternalUnsafeMethods.UndoManagerGetUndoCount(ObjectPtr->ObjPtr);
      }

      public string GetUndoName(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.UndoManagerGetUndoName(ObjectPtr->ObjPtr, index));
      }

      public string GetRedoName(int index)
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.UndoManagerGetRedoName(ObjectPtr->ObjPtr, index));
      }

      public void Undo()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.UndoManagerUndo(ObjectPtr->ObjPtr);
      }

      public void Redo()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         InternalUnsafeMethods.UndoManagerRedo(ObjectPtr->ObjPtr);
      }

      public string GetNextUndoName()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.UndoManagerGetNextUndoName(ObjectPtr->ObjPtr));
      }

      public string GetNextRedoName()
      {
         if (IsDead()) throw new Exceptions.SimObjectPointerInvalidException();
         return Marshal.PtrToStringAnsi(InternalUnsafeMethods.UndoManagerGetNextRedoName(ObjectPtr->ObjPtr));
      }
      
      #endregion

      
   }
}